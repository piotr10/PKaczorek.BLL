using System.Reflection;

namespace PKaczorek.BL
{
    public class WyswietlaniePozycjiZamowienia
    {
        public int PozycjaZamowieniaid { get;private set; }
        public int Ilosc { get; set; }
        public string NazwaProduktu { get; set; }
        public decimal? CenaZakupu { get; set; }

    }
}