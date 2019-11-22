using System;

namespace Common
{
    public static class ObslugaStringa // klasa ktora ze zwyklej klasy stala sie - statyczna 
    {
        public static string WstawSpacje(this string zrodlo) // WstawSpacje staje sie metoda rozszerzen - extensions method
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
