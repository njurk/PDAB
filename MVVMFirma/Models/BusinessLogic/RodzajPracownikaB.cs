﻿using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.Models.BusinessLogic
{
    public class RodzajPracownikaB : DatabaseClass
    {
        #region Constructor
        public RodzajPracownikaB(HotelEntities db)
            : base(db) { }
        #endregion

        #region Funkcje biznesowe
        public IQueryable<KeyAndValue> GetRodzajPracownikaKeyAndValueItems()
        {
            return
                (
                    from rodzajpracownika in db.RodzajPracownika
                    select new KeyAndValue
                    {
                        Key = rodzajpracownika.IdRodzajuPracownika,
                        Value = rodzajpracownika.Nazwa
                    }
                ).ToList().AsQueryable();
        }
        #endregion
    }
}