using System.Collections.Generic;

namespace Scores.Models
{
    
    public struct sMain
    {
        public List<sLeague> League;
    }

    public struct sMatch
    {
        public sTeam Home;
        public sTeam Guest;
        public string HomeGoal;
        public string GuestGoal;
        public string Status;
        public string Date;
    }

    public struct sTeam
    {
        public string Name;
    }

    public struct sLeague
    {
        public string Name;
        public List<sRound> Rounds;
    }

    public struct sRound
    {
        public string Name;
        public List<sMatch> Matches;
    }

}
