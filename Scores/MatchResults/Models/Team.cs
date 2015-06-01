using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchResults.Models
{
    public class Team
    {

        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public int IdLeague { get; set; }
       
        public int Points { get; set; }
        
        public int Win { get; set; }
       
        public int Draw { get; set; }
        
        public int Lose { get; set; }
        
        public int GoalScored { get; set; }
        
        public int GoalConceded { get; set; }

    }

}
