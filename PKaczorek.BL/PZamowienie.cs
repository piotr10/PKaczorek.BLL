using System;
using System.Collections.Generic;

namespace PKaczorek.BLTest
{
    public class PZamowienie
    {
        #region Konstruktory

        public PZamowienie()
        {
            
        }

        public PZamowienie(int zamowienieId)
        {
            zamowienieId = ZamowienieId;
        }
        #endregion

        #region Właściwości

        public int ZamowienieId { get; private set; }
        public DateTimeOffset? DataZamowinia { get; set; }

        #endregion

        #region Metody

        /// <summary>
        /// Sprawdza dane zamowienia
        /// </summary>
        /// <returns></returns>
        public bool Zwaliduj()
        {
            var poprawne = true;
            
            if (DataZamowinia == null)
            {
                poprawne = false;
            }
            return poprawne;
        }
        /// <summary>
        /// metoda ta zapisuje zamowienie
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            return true;
        }

        /// <summary>
        /// Pobieramy jedeno zamowienie
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public PZamowienie Pobierz(int zamowienieId)
        {
            return new PZamowienie();
        }

        /// <summary>
        /// kod pobiera wszystkie zamowienia
        /// </summary>
        /// <returns></returns>
        public List<PZamowienie> Pobierz()
        {
            return new List<PZamowienie>();
        }


        #endregion
    }
}