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
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
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
    
        public virtual ObjectResult<listerCoursUnEtudiant_Result> listerCoursUnEtudiant(string no_da)
        {
            var no_daParameter = no_da != null ?
                new ObjectParameter("no_da", no_da) :
                new ObjectParameter("no_da", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listerCoursUnEtudiant_Result>("listerCoursUnEtudiant", no_daParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> compterCours(string session)
        {
            var sessionParameter = session != null ?
                new ObjectParameter("session", session) :
                new ObjectParameter("session", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("compterCours", sessionParameter);
        }
    
        public virtual int compterCoursOutPut(string session, ObjectParameter nbre_cours)
        {
            var sessionParameter = session != null ?
                new ObjectParameter("session", session) :
                new ObjectParameter("session", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("compterCoursOutPut", sessionParameter, nbre_cours);
        }
    
        public virtual ObjectResult<listerSelonNom_Result> listerSelonNom(string nom)
        {
            var nomParameter = nom != null ?
                new ObjectParameter("nom", nom) :
                new ObjectParameter("nom", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listerSelonNom_Result>("listerSelonNom", nomParameter);
        }
    }
}
