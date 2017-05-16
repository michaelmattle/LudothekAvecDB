//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LudothekWeb_M133.Storage
{
    using System;
    using System.Collections.Generic;
    
    public partial class Filiale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Filiale()
        {
            this.Bestellung = new HashSet<Bestellung>();
            this.Kunde = new HashSet<Kunde>();
            this.Mitarbeiter = new HashSet<Mitarbeiter>();
            this.Spiel = new HashSet<Spiel>();
        }
    
        public System.Guid FilialKeyGUID { get; set; }
        public string Vereinsname { get; set; }
        public string Strasse { get; set; }
        public string Ort { get; set; }
        public int PLZ { get; set; }
        public System.Guid FK_Verband { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bestellung> Bestellung { get; set; }
        public virtual Verband Verband { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kunde> Kunde { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mitarbeiter> Mitarbeiter { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Spiel> Spiel { get; set; }
    }
}
