using System;
using System.Collections.Generic;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PKaczorek.BL;
using PKaczorek.BLTest;

namespace CommonTest
{
    [TestClass]
    public class UslugaLogowanieTest
    {
        [TestMethod]
        public void PiszDoPliku()
        {
            //Arrange
            var zmienioneElementy = new List<ILogowanie>();
            var klient = new PKlient(1)
            {
                Email = "piotr.wp.pl",
                Imie = "Piotr",
                Nazwisko = "Czerski",
                ListaAdresow = null
            };

            zmienioneElementy.Add(klient as ILogowanie); // dodawanie klienta do listy za pomoca as ILogowanie

            var produkt = new PProdukt(5)
            {
                NazwaProduktu = "Klocki",
                opis = "Klocki dla dzieci",
                AktualnaCena = 10M
            };

            zmienioneElementy.Add(produkt as ILogowanie);

            var zamowienie = new PZamowienie(20)
            {
                DataZamowinia = new DateTime(2019, 9, 12, 11, 0, 0)
            };

            zmienioneElementy.Add(zamowienie as ILogowanie);

            //Act
            UslugaLogowanie.PiszDoPliku(zmienioneElementy);

            //Assert
        }
    }
}
