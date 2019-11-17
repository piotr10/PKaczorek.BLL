using System.Collections.Generic;

namespace PKaczorek.BLTest
{
    public class PPozycjaZamowienia
    {
        #region Konstruktory

        public PPozycjaZamowienia()
        {
            
        }

        public PPozycjaZamowienia(int pozycjaZamowieniaId)
        {
            pozycjaZamowieniaId = PozycjaZamowieniaId;
        }

        #endregion

        #region Właściwości

        public int PozycjaZamowieniaId { get; private set; }
        public int Ilosc { get; set; }
        public int ProduktId { get; set; }
        public decimal? CenaZakupu { get; set; }

        #endregion

        #region Metody

        /// <summary>
        /// Sprawdza dane pozycji zamowienia
        /// </summary>
        /// <returns></returns>
        public bool Zwaliduj()
        {
            var poprawne = true;

           if (Ilosc <= 0)
           {
                poprawne = false;
           } 

           if (ProduktId <= 0)
           {
                poprawne = false;
           } 

           if (CenaZakupu == null)
           {
                poprawne = false;
           }
            return poprawne;
        }

        /// <summary>
        /// metoda ta zapisuje pozycje zamowienia
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            return true;
        }

        /// <summary>
        /// Pobieramy jeden element
        /// </summary>
        /// <param name="pozycjaZamowieniaId"></param>
        /// <returns></returns>
        public PPozycjaZamowienia Pobierz(int pozycjaZamowieniaId)
        {
            return new PPozycjaZamowienia();
        }
        
        #endregion
    }
}