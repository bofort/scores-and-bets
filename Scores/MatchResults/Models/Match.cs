using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchResults.Models
{
    public class Match
    {

        public int Id { get; set; }

        public string HomeTeam { get; set; }

        public int HomeGoal { get; set; }

        public string GuestTeam { get; set; }

        public int GuestGoal { get; set; }

        public string Status { get; set; }

        public string Date { get; set; }

        public int IdRound { get; set; }

        public int IdLeague { get; set; }

        public bool IsUserMatch { get; set; }
    }
}
