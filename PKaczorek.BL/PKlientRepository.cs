using System.Collections.Generic;

namespace PKaczorek.BL
{
    public class PKlientRepository
    {
       /// <summary>
        /// Pobieramy jednego klienta
        /// </summary>
        /// <param name="klientId"></param>
        /// <returns></returns>
        public PKlient Pobierz(int klientId)
        {
            //Tworzymy istancje klasy klienta
            PKlient klient = new PKlient(klientId);

            //kod koóry pobiera określonego klienta z bazy danych

            //tymczasowo zakodowane wartopsci
            if (klientId == 1)
            {
                klient.Email = "piotr@wp.pl";
                klient.Imie = "marcin";
                klient.Nazwisko = "kowal";
            }

            return klient;
        }

        /// <summary>
        /// kod pobiera wszystkich klientów
        /// </summary>
        /// <returns></returns>
        public List<PKlient> Pobierz()
        {
            return new List<PKlient>();
        }

        public bool Zapisz()
        {
            return true;
        }
    }
}