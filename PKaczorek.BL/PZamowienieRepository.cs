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
        public bool Zapisz(PZamowienie zamowienie)
        {
            //kod ktory zapisuje zdefinowane zamowienie
            //kod ktory zapisuje zdefiniowany produkt
            var sukces = true;

            if (zamowienie.MaZmiany && zamowienie.DanePrawidlowe)
            {
                if (zamowienie.JestNowy)
                {
                    // wywołaj procedure insert
                }
                else
                {
                    // wywolaj procedure update
                }
            }
            return sukces;
        }

        /// <summary>
        /// pobieramy jedno zmaowienie do wyswietlenia
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public PWyswietlanieZamowienia PobierzZamowienieDoWyswietlenia(int zamowienieId)
        {
            PWyswietlanieZamowienia wyswietlanieZamowienia = new PWyswietlanieZamowienia();

            // kod ktory pobiera zdefinowane pola zamowienia z bazy danych

            //tymczasowo zakodowane dane na stale
            if (zamowienieId == 10)
            {
                wyswietlanieZamowienia.Imie = "jacek";
                wyswietlanieZamowienia.Nazwisko = "bury";
                wyswietlanieZamowienia.DataZamowienia = new DateTimeOffset(2019, 12, 12, 12, 00, 00, new TimeSpan(5,0,0));
                wyswietlanieZamowienia.AdresDostawy = new PAdres()
                {
                    AdresTyp = 2,
                    Ulica = "mila",
                    Miasto = "eloszka",
                    Kraj = "polska",
                    KodPocztowy = "12-123"
                };
                wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista = new List<WyswietlaniePozycjiZamowienia>();

                //kod ktory pobiera elementy zamowenia

                //dane zakodowane na stałe
                if (zamowienieId ==10)
                {
                    var wyswietlaniePozycjiZamowienia = new WyswietlaniePozycjiZamowienia()
                    {
                        NazwaProduktu = "stol",
                        CenaZakupu = 123.5M,
                        Ilosc = 5
                    };
                    wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista.Add(wyswietlaniePozycjiZamowienia);

                    wyswietlaniePozycjiZamowienia = new WyswietlaniePozycjiZamowienia()
                    {
                        NazwaProduktu = "blat",
                        CenaZakupu = 1232.5M,
                        Ilosc = 7
                    };
                    wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista.Add(wyswietlaniePozycjiZamowienia);
                }
            }
            return wyswietlanieZamowienia;
        }
    }
}