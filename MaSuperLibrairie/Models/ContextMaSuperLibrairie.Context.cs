﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MaSuperLibrairie.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class JeuDroidesEntities : DbContext
    {
        public JeuDroidesEntities()
            : base("name=JeuDroidesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Paragraphe> Paragraphe { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<Reponse> Reponse { get; set; }
    }
}
