//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LegendOfFall.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Winner
    {
        public int Id { get; set; }
        public int SeasonId { get; set; }
        public int ApplicantId { get; set; }
        public int PlaceTook { get; set; }
    
        public virtual Applicant Applicant { get; set; }
        public virtual Season Season { get; set; }
    }
}
