﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testtProject1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IDMBDataBaseEntities : DbContext
    {
        public IDMBDataBaseEntities()
            : base("name=IDMBDataBaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Actorr> Actorrs { get; set; }
        public virtual DbSet<Directorr> Directorrs { get; set; }
        public virtual DbSet<favourite_actorr> favourite_actorr { get; set; }
        public virtual DbSet<favourite_directorr> favourite_directorr { get; set; }
        public virtual DbSet<favourite_moviee> favourite_moviee { get; set; }
        public virtual DbSet<Like_or_dislike_moviee> Like_or_dislike_moviee { get; set; }
        public virtual DbSet<Moviee> Moviees { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<Userr> Userrs { get; set; }
        public virtual DbSet<Adminn1> Adminn1 { get; set; }
    }
}