
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
    
public partial class Usluga
{

    public int IdUslugi { get; set; }

    public int IdTypuUslugi { get; set; }

    public System.DateTime DataRozpoczeciaUslugi { get; set; }

    public System.DateTime DataZakonczeniaUslugi { get; set; }

    public int IdKlienta { get; set; }

    public Nullable<int> IdPlatnosci { get; set; }



    public virtual Klient Klient { get; set; }

    public virtual Platnosc Platnosc { get; set; }

    public virtual TypUslugi TypUslugi { get; set; }

}

}