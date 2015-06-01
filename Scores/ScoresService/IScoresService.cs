using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Text;
using Common.DataContracts;

namespace ScoresService
{

    [ServiceContract]
    public interface IScoresService
    {
        [OperationContract]
        List<Common.DataContracts.MATCH> GetAllMatches();

        [OperationContract]
        List<Common.DataContracts.MATCH> GetLiveMatches();

        [OperationContract]
        List<Common.DataContracts.BET> GetAllBets();

        [OperationContract]
        List<Common.DataContracts.TEAM> GetAllTeams();

        [OperationContract]
        List<Common.DataContracts.MATCH> GetUserMatches();

        [OperationContract]
        List<Common.DataContracts.BETS_MATCHES> GetMatchesForBet();

        [OperationContract]
        List<Common.DataContracts.LEAGUE> GetAllLeagues();

        [OperationContract]
        Common.DataContracts.BET GetBet(int id);

        [OperationContract]
        List<Common.DataContracts.TEAM> GetLeagueTable(int idLeague);

        [OperationContract]
        void AddLeague(Common.DataContracts.LEAGUE league);

        [OperationContract]
        void DeleteLeague(List<Common.DataContracts.LEAGUE> leagueList);

        [OperationContract]
        void AddToUserMatches(List<Common.DataContracts.MATCH> matchesList);

        [OperationContract]
        void DeleteFromMyMatches(List<Common.DataContracts.MATCH> matchesList);
    }
}
