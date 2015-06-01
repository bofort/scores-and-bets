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
    public class MATCH
    {
       
        public int ID { get; set; }
 
        public string HOME_TEAM { get; set; }
      
        public int HOME_GOAL { get; set; }
 
        public string GUEST_TEAM { get; set; }
        
        public int GUEST_GOAL { get; set; }
        
        public string STATUS { get; set; }
      
        public string DATE { get; set; }
       
        public int ID_ROUND { get; set; }
       
        public int ID_LEAGUE { get; set; }

    }
}
