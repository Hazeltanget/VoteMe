//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VoteMe.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class SurveryResult
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int SurveryID { get; set; }
        public string Answer { get; set; }
    
        public virtual Survery Survery { get; set; }
        public virtual User User { get; set; }
    }
}
