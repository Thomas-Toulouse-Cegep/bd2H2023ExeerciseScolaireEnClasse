﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wfa_casScolaireDepart
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TT_BDscolaireEntities1 : DbContext
    {
        public TT_BDscolaireEntities1()
            : base("name=TT_BDscolaireEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_cours> tbl_cours { get; set; }
        public virtual DbSet<tbl_etudiant> tbl_etudiant { get; set; }
        public virtual DbSet<tbl_resultat> tbl_resultat { get; set; }
    }
}