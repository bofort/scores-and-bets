using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DataContracts;
using MatchResults.Helpers;
using MatchResults.Models;
using MatchResults.ScoresService;

namespace MatchResults.DataAccess
{
    /// <summary>
    /// Klasa odpowiedzialna za komunikację z WCFem
    /// </summary>
    public class MatchesDataAccess
    {

        #region Method

        /// <summary>
        /// Pobiera mecze które trwają
        /// </summary>
        /// <returns></returns>
        public List<Match> GetLiveMatches()
        {
            return  Globals.ScoresClient.GetLiveMatches().Select(match => match.ToModel()).ToList();
        }


        /// <summary>
        /// Pobiera mecze obserwowane przez użytkownika
        /// </summary>
        /// <returns></returns>
        public List<Match> GetUserMatches()
        {
            return Globals.ScoresClient.GetUserMatches().Select(match => match.ToModel()).ToList();
        }

        /// <summary>
        /// Usuwa mecze obserwowane przez uzytkownika
        /// </summary>
        /// <param name="matchesList"></param>
        public void DeleteFromMyMatches(List<Match> matchesList)
        {
            Globals.ScoresClient.DeleteFromMyMatches(matchesList.Select(match => match.ToDTO()).ToArray());
        } 


        /// <summary>
        /// Dodaje mecze uzytkownika
        /// </summary>
        /// <param name="matchesList"></param>
        public void AddToMyMatches(List<Match> matchesList)
        {
            Globals.ScoresClient.AddToUserMatches(matchesList.Select(match => match.ToDTO()).ToArray());
        }

        #endregion

    }
}
