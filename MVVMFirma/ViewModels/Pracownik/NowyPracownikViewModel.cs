﻿using MVVMFirma.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.ViewModels
{
    public class NowyPracownikViewModel : JedenViewModel<Pracownik>
    {
        #region Constructor
        public NowyPracownikViewModel()
            :base("Pracownik")
        {
            item = new Pracownik();
        }
        #endregion

        #region Properties
        public int IdRodzajuPracownika
        {
            get
            {
                return item.IdRodzajuPracownika;
            }
            set
            {
                item.IdRodzajuPracownika = value;
                OnPropertyChanged(() => IdRodzajuPracownika);
            }
        }

        public string Imie
        {
            get
            {
                return item.Imie;
            }
            set
            {
                item.Imie = value;
                OnPropertyChanged(() => Imie);
            }
        }

        public string Nazwisko
        {
            get
            {
                return item.Nazwisko;
            }
            set
            {
                item.Nazwisko = value;
                OnPropertyChanged(() => Nazwisko);
            }
        }

        public string Ulica
        {
            get
            {
                return item.Ulica;
            }
            set
            {
                item.Ulica = value;
                OnPropertyChanged(() => Ulica);
            }
        }

        public string NrDomu
        {
            get
            {
                return item.NrDomu;
            }
            set
            {
                item.NrDomu = value;
                OnPropertyChanged(() => NrDomu);
            }
        }

        public string NrLokalu
        {
            get
            {
                return item.NrLokalu;
            }
            set
            {
                item.NrLokalu = value;
                OnPropertyChanged(() => NrLokalu);
            }
        }

        public string KodPocztowy
        {
            get
            {
                return item.KodPocztowy;
            }
            set
            {
                item.KodPocztowy = value;
                OnPropertyChanged(() => KodPocztowy);
            }
        }

        public string Miasto
        {
            get
            {
                return item.Miasto;
            }
            set
            {
                item.Miasto = value;
                OnPropertyChanged(() => Miasto);
            }
        }

        public string Kraj
        {
            get
            {
                return item.Kraj;
            }
            set
            {
                item.Kraj = value;
                OnPropertyChanged(() => Kraj);
            }
        }

        public DateTime DataUrodzenia
        {
            get
            {
                return item.DataUrodzenia;
            }
            set
            {
                item.DataUrodzenia = value;
                OnPropertyChanged(() => DataUrodzenia);
            }
        }

        public string Email
        {
            get
            {
                return item.Email;
            }
            set
            {
                item.Email = value;
                OnPropertyChanged(() => Email);
            }
        }

        public string Telefon
        {
            get
            {
                return item.Telefon;
            }
            set
            {
                item.Telefon = value;
                OnPropertyChanged(() => Telefon);
            }
        }
        #endregion

        #region Helpers
        public override void Save()
        {
            hotelEntities.Pracownik.Add(item);
            hotelEntities.SaveChanges();
        }
        #endregion
    }
}