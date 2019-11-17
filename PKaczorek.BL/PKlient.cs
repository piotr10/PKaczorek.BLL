using System;
using System.Runtime.InteropServices;

namespace PKaczorek.BL
{
    public class PKlient
    {
        #region Właściwości
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
            get { return Imie + ", " + Nazwisko; }
        }

        #endregion

        #region Konstruktory

        #endregion

        #region Metody

        #endregion
    }
}
