﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LOFEntities1 : DbContext
    {
        public LOFEntities1()
            : base("name=LOFEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AboutU> AboutUs { get; set; }
        public virtual DbSet<Applicant> Applicants { get; set; }
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<BlogPost> BlogPosts { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Judge> Judges { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<Season> Seasons { get; set; }
        public virtual DbSet<Season_Applicant> Season_Applicant { get; set; }
        public virtual DbSet<Season_Judge> Season_Judge { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Winner> Winners { get; set; }
    }
}