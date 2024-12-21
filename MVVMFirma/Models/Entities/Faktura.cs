
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
    
public partial class Faktura
{

    public int IdFaktury { get; set; }

    public int IdKlienta { get; set; }

    public string NIP { get; set; }

    public int IdRezerwacji { get; set; }

    public string NrFaktury { get; set; }

    public string Opis { get; set; }

    public System.DateTime DataWystawienia { get; set; }

    public System.DateTime DataSprzedazy { get; set; }

    public decimal KwotaNetto { get; set; }

    public decimal VAT { get; set; }

    public decimal KwotaBrutto { get; set; }

    public int IdPlatnosci { get; set; }

    public System.DateTime TerminPlatnosci { get; set; }



    public virtual Klient Klient { get; set; }

    public virtual Platnosc Platnosc { get; set; }

    public virtual Rezerwacja Rezerwacja { get; set; }

}

}