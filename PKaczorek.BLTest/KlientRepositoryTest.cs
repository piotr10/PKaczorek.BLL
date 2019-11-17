using System;
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

    }
}
