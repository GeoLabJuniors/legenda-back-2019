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
    
    public partial class Season_Judge
    {
        public int Id { get; set; }
        public int JudgeId { get; set; }
        public int SeasonId { get; set; }
    
        public virtual Judge Judge { get; set; }
        public virtual Season Season { get; set; }
    }
}