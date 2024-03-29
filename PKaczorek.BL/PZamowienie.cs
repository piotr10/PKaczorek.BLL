﻿using System;
using System.Collections.Generic;
using Common;
using PKaczorek.BL;

namespace PKaczorek.BLTest
{
    public class PZamowienie : KlasaBazowa, ILogowanie
    {
        #region Konstruktory

        public PZamowienie()
        {
            
        }

        public PZamowienie(int zamowienieId)
        {
            ZamowienieId = zamowienieId;
        }
        #endregion

        #region Właściwości

        public int ZamowienieId { get; private set; }
        public DateTimeOffset? DataZamowinia { get; set; }

        public List<PPozycjaZamowienia> pozycjaZamowienia { get; set; }
        public int KlientId { get; set; }
        public int AdresDostawyId { get; set; }

        #endregion

        #region Metody

        /// <summary>
        /// Sprawdza dane zamowienia
        /// </summary>
        /// <returns></returns>
        public override bool Zwaliduj()
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

        public override string ToString()
        {
            return DataZamowinia.Value.Date + " (" + ZamowienieId + ")";
        }

        public string Log()
        {
            var log = ZamowienieId + ": " + 
                      "Data: " + DataZamowinia.Value.Date + " " + 
                      "Status: " + StanObiektu.ToString();
            return log;
        }

        #endregion
    }
}