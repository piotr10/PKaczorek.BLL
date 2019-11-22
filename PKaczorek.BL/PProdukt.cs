using System;
using System.Collections.Generic;
using Common;
using PKaczorek.BL;

namespace PKaczorek.BLTest
{
    public class PProdukt : KlasaBazowa, ILogowanie
    {
        #region Konstruktory

        public PProdukt()
        {

        }

        public PProdukt(int produktId)
        {
            ProduktId = produktId;
        }

        #endregion

        #region Właściwości

        public int ProduktId { get; private set; }
        public decimal? AktualnaCena  { get; set; }
        public string opis { get; set; }
       
        private string _NazwaProduktu;
        public string NazwaProduktu
        {
            get
            {
               //var obslugaStringa = new ObslugaStringa();
                //return obslugaStringa.WstawSpacje(_NazwaProduktu);

                //return ObslugaStringa.WstawSpacje(_NazwaProduktu); //z klasy static

                return _NazwaProduktu.WstawSpacje(); // metoda rozszerzeń
            }
            set { _NazwaProduktu = value; }
        }

        #endregion

        #region Metody

        /// <summary>
        /// Sprawdza dane produktu
        /// </summary>
        /// <returns></returns>
        public override bool Zwaliduj()
        {
            var poprawne = true;

            if (string.IsNullOrWhiteSpace(NazwaProduktu))
            {
                poprawne = false;
            }
            if (AktualnaCena == null)
            {
                poprawne = false;
            }
            return poprawne;
        }

        /// <summary>
        /// metoda ta zapisuje produkt
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            return true;
        }

        /// <summary>
        /// Pobieramy jeden produkt
        /// </summary>
        /// <param name="produktId"></param>
        /// <returns></returns>
        public PProdukt Pobierz(int produktId)
        {
            return new PProdukt();
        }

        /// <summary>
        /// kod pobiera wszystkie produkty
        /// </summary>
        /// <returns></returns>
        public List<PProdukt> Pobierz()
        {
            return new List<PProdukt>();
        }

        public override string ToString()
        {
            return NazwaProduktu;
        }
        public string Log() //dane ktore beda rejestrowane przez metode Log()
        {
            var log = ProduktId + ": " +
                      NazwaProduktu + " " +
                      "Opis: " + opis +
                      " Status: " + StanObiektu.ToString();
            return log;
        }

        #endregion

    }
}