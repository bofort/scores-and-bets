﻿using System;
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
    public class BETS_MATCHES
    {

        public int ID { get; set; }

        public int ID_BET { get; set; }

        public int ID_MATCH { get; set; }

        public int TYPE { get; set; }

    }
}
