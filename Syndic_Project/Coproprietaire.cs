//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Syndic_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class Coproprietaire
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Coproprietaire()
        {
            this.Paiements = new HashSet<Paiement>();
        }
    
        public int CinCop { get; set; }
        public string NomCop { get; set; }
        public string PrenomCop { get; set; }
        public string Email { get; set; }
        public Nullable<int> Tel { get; set; }
        public Nullable<int> NumLogement { get; set; }
    
        public virtual Logement Logement { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Paiement> Paiements { get; set; }
    }
}
