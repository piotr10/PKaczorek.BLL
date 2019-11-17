using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace PKaczorek.BL
{
    public class PKlient
    {
        #region Konstruktory

        public PKlient()
        {
            
        }

        public PKlient(int klient)
        {
            klient = KlientId;
        }

        #endregion

        #region Właściwości

        public static int Licznik { get; set; }
        private string _nazwisko;
        public string  Nazwisko
        {
            get
            {
                //tutaj mozemy dodac dowolny kod
                return _nazwisko;
            }
            set
            {
                //tutaj mozemy dodac dowolny kod
                _nazwisko = value;
            }
        }
        public string Imie { get; set; }
        public string Email { get; set; }
        public int KlientId { get; private set; }

        public string ImieNazwisko
        {
            get
            {
                string imieNazwisko = Imie;
                if (!string.IsNullOrWhiteSpace(Nazwisko))
                {
                    if (!string.IsNullOrWhiteSpace(imieNazwisko)) // ! - jeżeli nie jest 
                    {
                        imieNazwisko += ", ";
                    }
                    imieNazwisko += Nazwisko;
                }
                return imieNazwisko;
            }
        }

        #endregion
     
        #region Metody

        public bool Zwaliduj()
        {
            var poprawne = true;

            if (string.IsNullOrWhiteSpace(Nazwisko))
            {
                poprawne = false;
            }
            if (string.IsNullOrWhiteSpace(Email))
            {
                poprawne = false;
            }
            return poprawne;
        }
       
        /// <summary>
        /// Pobieramy jednego klienta
        /// </summary>
        /// <param name="klientId"></param>
        /// <returns></returns>
        public PKlient Pobierz(int klientId)
        {
            return new PKlient();
        }

        /// <summary>
        /// kod pobiera wszystkich klientów
        /// </summary>
        /// <returns></returns>
        public List<PKlient> Pobierz()
        {
            return new List<PKlient>();
        }

        /// <summary>
        /// metoda ta zapisuje kliena
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            return true;
        }
        #endregion

    }
}
