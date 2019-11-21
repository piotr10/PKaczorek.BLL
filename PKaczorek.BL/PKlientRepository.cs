using System.Collections.Generic;
using System.Linq;

namespace PKaczorek.BL
{
    public class PKlientRepository
    {
        private AdresRepository adresRepository { get; set; } //ta właściwośc i konstruktor pod spodem PKlientRepository przechowują adresy w KlientRepository

        public PKlientRepository()
        {
            adresRepository = new AdresRepository();
        }

       /// <summary>
        /// Pobieramy jednego klienta
        /// </summary>
        /// <param name="klientId"></param>
        /// <returns></returns>
        public PKlient Pobierz(int klientId)
        {
            //Tworzymy istancje klasy klienta
            PKlient klient = new PKlient(klientId);
            klient.ListaAdresow = adresRepository.PobierzPoKlientId(klientId).ToList();

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

        /// <summary>
        /// zapisuje klienta
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            //kod ktory zapisuje zdefiniowanego klienta
            return true;
        }

    }
}