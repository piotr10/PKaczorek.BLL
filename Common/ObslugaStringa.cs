using System;

namespace Common
{
    public class ObslugaStringa
    {
        public string WstawSpacje(string zrodlo)
        {
            string wynik = string.Empty; //inicjalizacja zmiennej wynik ktora bedzie wartoscia zwracaną
            if (!string.IsNullOrWhiteSpace(zrodlo)) //spr czy ciąg zrodlo zawiera puste znaki 
            {
                foreach (var litera in zrodlo)
                {
                    if (char.IsUpper(litera)) //szukamy wielkiej litery i jezeli ja znajdzie to wstawiamy spacje
                    {
                        wynik += " "; // wstawiamy sapcje jezeli if znajdzie wielka litere IsUpper(litera)
                        
                    }
                    wynik += litera; // przekazujemy litere do zrodlo i jezeli jest to wielka litera to wstawia spacje 
                    wynik = wynik.Trim();
                }
            }
            return wynik; //zwracamy wynik - przetworzony string w ktorym jest wstawiona spacja
        }
    }
}
