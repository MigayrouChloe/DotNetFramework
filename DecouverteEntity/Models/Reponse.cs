//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DecouverteEntity.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reponse
    {
        public decimal Id { get; set; }
        public string Texte { get; set; }
        public decimal QuestionId { get; set; }
    
        public virtual Question Question { get; set; }
    }
}
