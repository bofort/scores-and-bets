using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchResults.Models
{
    public class League
    {
      
        public int Id { get; set; }
        
        public string Name { get; set; }
      
        public string Link { get; set; }

        public bool IsDeleteLeague { get; set; }

    }
}
