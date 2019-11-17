using System.Collections.Generic;

namespace PKaczorek.BL
{
    public class AdresRepository
    {
        /// <summary>
        /// Pobieramy jeden adres
        /// </summary>
        /// <param name="adresId"></param>
        /// <returns></returns>
        public PAdres Pobierz(int adresId)
        {
            //Tworzymy istancje klasy adres i przekazujemy zadany identyfiaktor
            PAdres adres = new PAdres(adresId);

            //kod który pobiera zdefinowany adres

            //tymczasowo zakodowane wartosci
            if (adresId == 1)
            {
                adres.AdresTyp = 1;
                adres.Ulica = "Fajna";
                adres.Miasto = "Warszawa";
                adres.Kraj = "Polska";
                adres.KodPocztowy = "01-000";
            }

            return adres;
        }

        /// <summary>
        /// pobieramy wszystkie zdefinowane adresy dla klienta o przekazanym klientId
        /// </summary>
        /// <param name="klientId"></param>
        /// <returns></returns>
        public IEnumerable<PAdres> PobierzPoKlientId(int klientId)
        {
            //kod który pobiera zdefinowany adres dla klienta

            //tymczasowo zakodowane wartosci do zwrocenia, zestaw adresow
            var listaAdresow = new List<PAdres>();

            PAdres adres = new PAdres(1)
            {
                AdresTyp = 1,
                Ulica = "Adama",
                Miasto = "Opole",
                Kraj = "Polska",
                KodPocztowy = "11-100"
            };
            listaAdresow.Add(adres);

            adres = new PAdres(2)
            {
                AdresTyp = 3,
                Ulica = "Asama",
                Miasto = "Wilno",
                Kraj = "Polska",
                KodPocztowy = "42-213"
            };
            listaAdresow.Add(adres);

            return listaAdresow;
        }

        /// <summary>
        /// zapisuje aktualny adres
        /// </summary>
        /// <param name="adres"></param>
        /// <returns></returns>
        public bool Zapisz(PAdres adres)
        {
            //kod ktory zapisuje zdefiniowany adres

            return true;
        }
    }
}