﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TravailBDPart4
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bd_natationEntities : DbContext
    {
        public bd_natationEntities()
            : base("name=bd_natationEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_Categori_Compet> tbl_Categori_Compet { get; set; }
        public virtual DbSet<tbl_Categorie_Nageur> tbl_Categorie_Nageur { get; set; }
        public virtual DbSet<tbl_Competition> tbl_Competition { get; set; }
        public virtual DbSet<tbl_Nageur> tbl_Nageur { get; set; }
        public virtual DbSet<tbl_Resultat> tbl_Resultat { get; set; }
    }
}