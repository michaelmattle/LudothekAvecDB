//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ludothek.Storage.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tarifkategorie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tarifkategorie()
        {
            this.Spiel = new HashSet<Spiel>();
        }
    
        public System.Guid TarifkategorieKeyGUID { get; set; }
        public string Bezeichnung { get; set; }
        public decimal Preis { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Spiel> Spiel { get; set; }
    }
}
