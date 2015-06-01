using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatchResults.Helpers;
using MatchResults.Models;
using MatchResults.ScoresService;

namespace MatchResults.DataAccess
{
    /// <summary>
    /// Klasa odpowiedzialna za komunikację z WCFem
    /// </summary>
    public class LeagueDataAccess
    {

        #region Method

        /// <summary>
        /// Pobiera liste lig
        /// </summary>
        /// <returns></returns>
        public List<League> GetLeaguesList()
        {
            return Globals.ScoresClient.GetAllLeagues().Select(l => l.ToModel()).ToList();
        }

        /// <summary>
        /// Pobiera tabele dla ligi
        /// </summary>
        /// <param name="idLeague"></param>
        /// <returns></returns>
        public List<Team> GetLeagueTable(int idLeague)
        {
            return Globals.ScoresClient.GetLeagueTable(idLeague).Select(t => t.ToModel()).ToList();
        }

        /// <summary>
        /// Dodaje nową ligę
        /// </summary>
        /// <param name="league"></param>
        public void AddLeague(League league)
        {
            Globals.ScoresClient.AddLeague(league.ToDTO());
        }

        /// <summary>
        /// Usuwa ligę
        /// </summary>
        /// <param name="leagueList"></param>
        public void DeleteLeague(List<League> leagueList)
        {
            Globals.ScoresClient.DeleteLeague(leagueList.Select(l => l.ToDTO()).ToArray());
        }

        #endregion

    }
}
