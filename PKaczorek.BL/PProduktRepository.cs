using System.Collections.Generic;
using PKaczorek.BLTest;

namespace PKaczorek.BL
{
    public class PProduktRepository
    {
        /// <summary>
        /// Pobieramy jeden produkt
        /// </summary>
        /// <param name="produktId"></param>
        /// <returns></returns>
        public PProdukt Pobierz(int produktId)
        {
            //tworzenie instancji produktu 
            PProdukt produkt = new PProdukt(produktId);
            
            //kod ktory pobiera tymczasowo okreslony produkt z bazy danych

            //tymczasowo zakodowane wartosci aby zwrocic produkt
            if (produktId == 5)
            {
                produkt.NazwaProduktu = "klocki";
                produkt.opis = "klocki dla dziecki";
                produkt.AktualnaCena = 123.123M;
            }

            return produkt;
        }

        /// <summary>
        /// kod pobiera wszystkie produkty
        /// </summary>
        /// <returns></returns>
        public List<PProdukt> Pobierz()
        {
            return new List<PProdukt>();
        }

        /// <summary>
        /// metoda ta zapisuje produkt
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            return true;
        }
    }
}