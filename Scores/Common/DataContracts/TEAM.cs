using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common.DataContracts
{
    /// <summary>
    /// (Docelowo obiekt DTO - przepraszam za złe nazewnictwo)
    /// </summary>
    public class TEAM
    {

        public int ID { get; set; }
       
        public string NAME { get; set; }
        
        public int ID_LEAGUE { get; set; }
        
        public int POINTS { get; set; }
       
        public int WIN { get; set; }
       
        public int DRAW { get; set; }
    
        public int LOSE { get; set; }
        
        public int GOAL_SCORED { get; set; }
        
        public int GOAL_CONCEDED { get; set; }

    }
}
