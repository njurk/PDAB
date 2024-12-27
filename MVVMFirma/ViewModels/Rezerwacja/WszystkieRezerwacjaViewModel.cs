﻿using MVVMFirma.Models.Entities;
using MVVMFirma.Models.EntitiesForView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace MVVMFirma.ViewModels
{
    public class WszystkieRezerwacjaViewModel : WszystkieViewModel<RezerwacjaForAllView>
    {
        #region Constructor
        public WszystkieRezerwacjaViewModel()
        {
            base.DisplayName = "Rezerwacje";
        }
        #endregion

        #region Helpers
        public override void Load()
        {
            List = new ObservableCollection<RezerwacjaForAllView>
                (
                    from rezerwacja in hotelEntities.Rezerwacja
                    select new RezerwacjaForAllView
                    {
                        IdRezerwacji = rezerwacja.IdRezerwacji,
                        KlientImie = rezerwacja.Klient.Imie,
                        KlientNazwisko = rezerwacja.Klient.Nazwisko,
                        NrPokoju = rezerwacja.Pokoj.NrPokoju,
                        LiczbaDoroslych = rezerwacja.LiczbaDoroslych,
                        LiczbaDzieci = rezerwacja.LiczbaDzieci,
                        CzyZwierzeta = rezerwacja.CzyZwierzeta,
                        DataZameldowania = rezerwacja.DataZameldowania,
                        DataWymeldowania = rezerwacja.DataWymeldowania,
                        DataRezerwacji = rezerwacja.DataRezerwacji,
                        Uwagi = rezerwacja.Uwagi,
                        Kwota = rezerwacja.Kwota
                    }
                );
        }

        #endregion
    }
}
