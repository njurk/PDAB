//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVVMFirma.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rezerwacja
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rezerwacja()
        {
            this.Faktura = new HashSet<Faktura>();
            this.Platnosc = new HashSet<Platnosc>();
            this.Usluga = new HashSet<Usluga>();
        }
    
        public int IdRezerwacji { get; set; }
        public int IdKlienta { get; set; }
        public int IdPokoju { get; set; }
        public string LiczbaDoroslych { get; set; }
        public string LiczbaDzieci { get; set; }
        public bool CzyZwierzeta { get; set; }
        public System.DateTime DataZameldowania { get; set; }
        public System.DateTime DataWymeldowania { get; set; }
        public System.DateTime DataRezerwacji { get; set; }
        public string Uwagi { get; set; }
        public decimal Kwota { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Faktura> Faktura { get; set; }
        public virtual Klient Klient { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Platnosc> Platnosc { get; set; }
        public virtual Pokoj Pokoj { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usluga> Usluga { get; set; }
    }
}
