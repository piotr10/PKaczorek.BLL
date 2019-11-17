using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PKaczorek.BL;

namespace PKaczorek.BLTest
{
    [TestClass]
    public class ZamowienieRepositoryTest
    {
        [TestMethod]
        public void PobierzZamowienieTest()
        {
            //Arrange
            var produktRepository = new PZamowienieRepository();
            var oczekiwana = new PZamowienie(10)
            {
                DataZamowinia = new DateTimeOffset(2018, 4, 20, 11, 00, 00, new TimeSpan(7, 0, 0))
            };

            //Act
            var aktualna = produktRepository.Pobierz(10);

            //Assert
            Assert.AreEqual(oczekiwana.ZamowienieId, aktualna.ZamowienieId);
            Assert.AreEqual(oczekiwana.DataZamowinia, aktualna.DataZamowinia);
            
        }
        
        [TestMethod]
        public void PobierzZamowienieDoWyswietleniaTest()
        {
            //Arrange
           var zamowienieRepository = new PZamowienieRepository();
           var oczekiwana = new PWyswietlanieZamowienia()
           {
               Imie = "jacek",
               Nazwisko = "bury",
               DataZamowienia = new DateTimeOffset(2019, 12, 12, 12, 00, 00, new TimeSpan(5, 0, 0)),
               AdresDostawy = new PAdres()
               {
                   AdresTyp = 2,
                   Ulica = "mila",
                   Miasto = "eloszka",
                   Kraj = "polska",
                   KodPocztowy = "12-123"
               },
               WyswietlaniePozycjiZamowieniaLista = new List<WyswietlaniePozycjiZamowienia>()
               {
                   new WyswietlaniePozycjiZamowienia()
                   {
                       NazwaProduktu = "stol",
                       CenaZakupu = 123.5M,
                       Ilosc = 5
                   },
                   new WyswietlaniePozycjiZamowienia()
                   {
                       NazwaProduktu = "blat",
                       CenaZakupu = 1232.5M,
                       Ilosc = 7
                   }
               }
           };

           //Act
           var aktualna = zamowienieRepository.PobierzZamowienieDoWyswietlenia(10);

            //Assert
            Assert.AreEqual(oczekiwana.ZamowienieId, aktualna.ZamowienieId);
            Assert.AreEqual(oczekiwana.DataZamowienia, aktualna.DataZamowienia);
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);

            Assert.AreEqual(oczekiwana.AdresDostawy.AdresTyp, aktualna.AdresDostawy.AdresTyp);
            Assert.AreEqual(oczekiwana.AdresDostawy.Ulica, aktualna.AdresDostawy.Ulica);
            Assert.AreEqual(oczekiwana.AdresDostawy.Miasto, aktualna.AdresDostawy.Miasto);
            Assert.AreEqual(oczekiwana.AdresDostawy.KodPocztowy, aktualna.AdresDostawy.KodPocztowy);
            Assert.AreEqual(oczekiwana.AdresDostawy.Kraj, aktualna.AdresDostawy.Kraj);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(oczekiwana.WyswietlaniePozycjiZamowieniaLista[1].NazwaProduktu, aktualna.WyswietlaniePozycjiZamowieniaLista[1].NazwaProduktu);
                Assert.AreEqual(oczekiwana.WyswietlaniePozycjiZamowieniaLista[1].Ilosc, aktualna.WyswietlaniePozycjiZamowieniaLista[1].Ilosc);
                Assert.AreEqual(oczekiwana.WyswietlaniePozycjiZamowieniaLista[1].CenaZakupu, aktualna.WyswietlaniePozycjiZamowieniaLista[1].CenaZakupu);

            }

        }
    }
}
