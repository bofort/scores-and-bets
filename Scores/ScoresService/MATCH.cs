//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScoresService
{
    using System;
    using System.Collections.Generic;
    
    public partial class MATCH
    {
        public int ID { get; set; }
        public string HOME_TEAM { get; set; }
        public Nullable<int> HOME_GOAL { get; set; }
        public string GUEST_TEAM { get; set; }
        public Nullable<int> GUEST_GOAL { get; set; }
        public string STATUS { get; set; }
        public string DATE { get; set; }
        public Nullable<int> ID_ROUND { get; set; }
        public Nullable<int> ID_LEAGUE { get; set; }
    }
}