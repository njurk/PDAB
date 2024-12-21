﻿using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.Models.BusinessLogic
{
    public class PracownikB : DatabaseClass
    {
        #region Constructor
        public PracownikB(HotelEntities db)
            : base(db) { }
        #endregion

        #region Funkcje biznesowe
        public IQueryable<KeyAndValue> GetPracownikKeyAndValueItems()
        {
            return
                (
                    from pracownik in db.Pracownik
                    select new KeyAndValue
                    {
                        Key = pracownik.IdPracownika,
                        Value = pracownik.Imie + " " + pracownik.Nazwisko
                    }
                ).ToList().AsQueryable();
        }
        #endregion
    }
}