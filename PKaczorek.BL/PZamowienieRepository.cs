using System;
using System.Collections.Generic;
using PKaczorek.BLTest;

namespace PKaczorek.BL
{
    public class PZamowienieRepository
    {
        /// <summary>
        /// Pobieramy jedeno zamowienie
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public PZamowienie Pobierz(int zamowienieId)
        {
            PZamowienie zamowienie = new PZamowienie(zamowienieId);
            //kod ktory pobiera okreslony produkt z bazy dancyh

            //tymczasowo zakodowane wartosci
            if (zamowienieId == 10)
            {
                zamowienie.DataZamowinia = new DateTimeOffset(2018, 4, 20, 11, 00, 00, new TimeSpan(7,0,0)); //time span - przsuniecie czasu o 7 godzin lub inna wartosc wpisana
            }

            return zamowienie;
        }

        /// <summary>
        /// kod pobiera wszystkie zamowienia
        /// </summary>
        /// <returns></returns>
        public List<PZamowienie> Pobierz()
        {
            return new List<PZamowienie>();
        }

        /// <summary>
        /// metoda ta zapisuje zamowienie
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            return true;
        }
    }
}