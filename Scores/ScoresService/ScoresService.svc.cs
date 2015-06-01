using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Common.DataContracts;
using ScoresService.Helpers;


namespace ScoresService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ScoresService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ScoresService.svc or ScoresService.svc.cs at the Solution Explorer and start debugging.
    public class ScoresService : IScoresService
    {

        /// <summary>
        /// Metoda zwracająca wszystkie mecze
        /// </summary>
        /// <returns></returns>
        public List<Common.DataContracts.MATCH> GetAllMatches()
        {
            var matches = new List<Common.DataContracts.MATCH>();
            try
            {
                using (var db = new SCORESEntities())
                {
                    var _matches = db.MATCH.ToList();
                    matches.AddRange(_matches.Select(m => m.ToCommon()));
                }
            }
            catch (Exception exception)
            {

            }
            return matches;
        }

        /// <summary>
        /// Metoda zwracająca mecze, które trwają
        /// </summary>
        /// <returns></returns>
        public List<Common.DataContracts.MATCH> GetLiveMatches()
        {
            var matches = new List<Common.DataContracts.MATCH>();
            try
            {
                using (var db = new SCORESEntities())
                {
                    var _matches = db.MATCH.Where(s => s.STATUS != "Koniec" && s.STATUS != string.Empty).ToList();
                    matches.AddRange(_matches.Select(m => m.ToCommon()));
                }
            }
            catch (Exception exception)
            {

            }
            return matches;
        }

        /// <summary>
        /// Metoda zwracająca wszystkie zakłądy
        /// </summary>
        /// <returns></returns>
        public List<Common.DataContracts.BET> GetAllBets()
        {
            var bets = new List<BET>();
            try
            {
                using (var db = new SCORESEntities())
                {
                    var _bets = db.BETS.ToList();
                    bets.AddRange(_bets.Select(b => b.ToCommon()));
                }
            }
            catch (Exception exception)
            {

            }
            return bets;
        }


        /// <summary>
        /// Metoda pobiera wszystkie zespoły
        /// </summary>
        /// <returns></returns>
        public List<Common.DataContracts.TEAM> GetAllTeams()
        {
            var teams = new List<Common.DataContracts.TEAM>();
            try
            {
                using (var db = new SCORESEntities())
                {
                    var _teams = db.TEAM.ToList();
                    teams.AddRange(_teams.Select(t => t.ToCommon()));
                }
            }
            catch (Exception exception)
            {

            }
            return teams;
        }


        /// <summary>
        /// Metoda pobiera mecze, które obserwuje użytkownik
        /// </summary>
        /// <returns></returns>
        public List<Common.DataContracts.MATCH> GetUserMatches()
        {
            var userMatches = new List<Common.DataContracts.MATCH>();
            try
            {
                using (var db = new SCORESEntities())
                {
                    var _matches = db.USER_MATCH.Select(match => db.MATCH.FirstOrDefault(m => m.ID == match.ID_MATCH)).ToList();
                    userMatches.AddRange(_matches.Select(m => m.ToCommon()));
                }
            }
            catch (Exception exception)
            {

            }
            return userMatches;
        }

        /// <summary>
        /// Metoda zwracajaca mecze dla danego zakładu
        /// </summary>
        /// <returns></returns>
        public List<Common.DataContracts.BETS_MATCHES> GetMatchesForBet()
        {
            var betsMatches = new List<Common.DataContracts.BETS_MATCHES>();
            try
            {
                using (var db = new SCORESEntities())
                {
                    var _betsMatches = db.BETS_MATCHES.ToList();
                    betsMatches.AddRange(_betsMatches.Select(b => b.ToCommon()));
                }
            }
            catch (Exception exception)
            {

            }
            return betsMatches;
        }

        /// <summary>
        /// Metoda pobierająca pełna listę lig
        /// </summary>
        /// <returns></returns>
        public List<Common.DataContracts.LEAGUE> GetAllLeagues()
        {
            var leagues = new List<Common.DataContracts.LEAGUE>();
            try
            {
                using (var db = new SCORESEntities())
                {
                    var _leagues = db.LEAGUE.ToList();
                    leagues.AddRange(_leagues.Select(l => l.ToCommon()));
                }
            }
            catch (Exception exception)
            {

            }
            return leagues;
        }

        /// <summary>
        /// Metoda pobiera jeden zakład
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Common.DataContracts.BET GetBet(int id)
        {
            var bet = new BET();
            try
            {
                using (var db = new SCORESEntities())
                {
                    var _bet = db.BETS.First(b => b.ID == id);
                    bet = _bet.ToCommon();
                }
            }
            catch (Exception exception)
            {

            }
            return bet;
        }

        /// <summary>
        /// Metoda pobiera aktualna tabele ligi
        /// </summary>
        /// <param name="idLeague"></param>
        /// <returns></returns>
        public List<Common.DataContracts.TEAM> GetLeagueTable(int idLeague)
        {
            var leagueTable = new List<Common.DataContracts.TEAM>();
            try
            {
                using (var db = new SCORESEntities())
                {
                    var _leagueTable = db.TEAM.OrderByDescending(team => team.POINTS).Where(team => team.ID_LEAGUE == idLeague).ToList();
                    leagueTable.AddRange(_leagueTable.Select(t => t.ToCommon()));
                }
            }
            catch (Exception exception)
            {

            }
            return leagueTable;
        }

        /// <summary>
        /// Metoda dodaje mecze obserwowane przez uzytkownika
        /// </summary>
        /// <param name="matchesList"></param>
        public void AddToUserMatches(List<Common.DataContracts.MATCH> matchesList)
        {
            try
            {
                using (var db = new SCORESEntities())
                {
                    var userMatch = matchesList.Select(x => x.ToDB()).Select(match => new USER_MATCH { ID_MATCH = match.ID }).ToList();
                    foreach (var match in userMatch)
                    {
                        var dbMatch = db.USER_MATCH.Any(x => x.ID_MATCH == match.ID_MATCH);
                        if (!dbMatch)
                        {
                            db.USER_MATCH.Add(match);
                        }
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {

            }
        }

        /// <summary>
        /// Metoda dodająca nową ligę
        /// </summary>
        /// <param name="league"></param>
        public void AddLeague(Common.DataContracts.LEAGUE league)
        {
            try
            {
                var leagues = league.ToDB();
                using (var db = new SCORESEntities())
                {
                    db.LEAGUE.Add(leagues);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {

            }
        }

        /// <summary>
        /// Metoda usuwająca mecze obserwowane przez uzytkownika
        /// </summary>
        /// <param name="matchesList"></param>
        public void DeleteFromMyMatches(List<Common.DataContracts.MATCH> matchesList)
        {
            try
            {
                using (var db = new SCORESEntities())
                {
                    var userMatch = matchesList.Select(x => x.ToDB()).Select(match => new USER_MATCH { ID_MATCH = match.ID }).ToList();
                    foreach (var match in userMatch.Select(match => db.USER_MATCH.FirstOrDefault(m => m.ID_MATCH == match.ID_MATCH)).Where(match => match != null))
                    {
                        db.USER_MATCH.Remove(match);
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {

            }
        }

        /// <summary>
        /// Metoda usuwająca wybrana ligę
        /// </summary>
        /// <param name="leagueList"></param>
        public void DeleteLeague(List<Common.DataContracts.LEAGUE> leagueList)
        {
            try
            {
                using (var db = new SCORESEntities())
                {
                    var leagues = leagueList.Select(x => x.ToDB()).Select(league => new LEAGUE() { ID = league.ID, NAME = league.NAME, LINK = league.LINK }).ToList();
                    foreach (var league in leagues.Select(league => db.LEAGUE.FirstOrDefault(m => m.ID == league.ID)).Where(league => league != null))
                    {
                        db.LEAGUE.Remove(league);
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {

            }
        }
    }
}
