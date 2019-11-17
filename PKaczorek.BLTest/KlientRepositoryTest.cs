using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PKaczorek.BL;

namespace PKaczorek.BLTest
{
    [TestClass]
    public class KlientRepositoryTest
    {
        [TestMethod]
        public void PobierzKlientaTest()
        {
            //Arrange
            var klientRepository = new PKlientRepository();
            var oczekiwana = new PKlient(1)
            {
                Email = "piotr@wp.pl",
                Imie = "marcin",
                Nazwisko = "kowal"
            };

            //Act
            var aktualna = klientRepository.Pobierz(1);

            //Assert
            Assert.AreEqual(oczekiwana.KlientId, aktualna.KlientId);
            Assert.AreEqual(oczekiwana.Email, aktualna.Email);
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);

        }

        [TestMethod]
        public void PobierzKlientaZAdresami()
        {
            //Arrange
            var klientRepository = new PKlientRepository();
            var oczekiwana = new PKlient(1)
            {
                Email = "piotr@wp.pl",
                Imie = "marcin",
                Nazwisko = "kowal",
                ListaAdresow = new List<PAdres>()
                {
                    new PAdres()
                    {
                        AdresTyp = 1,
                        Ulica = "Adama",
                        Miasto = "Opole",
                        Kraj = "Polska",
                        KodPocztowy = "11-100"
                    },

                    new PAdres()
                    {
                        AdresTyp = 3,
                        Ulica = "Asama",
                        Miasto = "Wilno",
                        Kraj = "Polska",
                        KodPocztowy = "42-213"
                    }
                }
            };

            //Act
            var aktualna = klientRepository.Pobierz(1);

            //Assert
            Assert.AreEqual(oczekiwana.KlientId, aktualna.KlientId);
            Assert.AreEqual(oczekiwana.Email, aktualna.Email);
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(oczekiwana.ListaAdresow[1].AdresTyp, aktualna.ListaAdresow[1].AdresTyp);
                Assert.AreEqual(oczekiwana.ListaAdresow[1].Ulica, aktualna.ListaAdresow[1].Ulica);
                Assert.AreEqual(oczekiwana.ListaAdresow[1].Miasto, aktualna.ListaAdresow[1].Miasto);
                Assert.AreEqual(oczekiwana.ListaAdresow[1].Kraj, aktualna.ListaAdresow[1].Kraj);
                Assert.AreEqual(oczekiwana.ListaAdresow[1].KodPocztowy, aktualna.ListaAdresow[1].KodPocztowy);
            }
        }
    }
}
