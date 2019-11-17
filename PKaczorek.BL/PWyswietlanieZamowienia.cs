using System;
using System.Collections.Generic;

namespace PKaczorek.BL
{
    public class PWyswietlanieZamowienia
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTimeOffset? DataZamowienia { get; set; }
        public List<WyswietlaniePozycjiZamowienia> WyswietlaniePozycjiZamowieniaLista { get; set; }
        public int ZamowienieId { get; set; }
        public PAdres AdresDostawy { get; set; }
    }
}