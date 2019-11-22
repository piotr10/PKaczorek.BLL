using System;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonTest
{
    [TestClass]
    public class ObslugaStringaTest
    {
        [TestMethod]
        public void WstawSpacjeTest()
        {
            //Arrange
            var zrodlo = "StółOgrodowy";
            var oczekiwana = "Stół Ogrodowy";
           //var obslugaStringa = new ObslugaStringa();

            //Act;
           // var aktualna = ObslugaStringa.WstawSpacje(zrodlo);
            var aktualna = zrodlo.WstawSpacje(); //metoda rozszerzen

            //Assert
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void WstawSpacjeTestZeSpacja()
        {
            //Arrange
            var zrodlo = "Stół Ogrodowy";
            var oczekiwana = "Stół Ogrodowy";
           // var obslugaStringa = new ObslugaStringa();

            //Act;
           //var aktualna = ObslugaStringa.WstawSpacje(zrodlo);
            var aktualna = zrodlo.WstawSpacje(); //metoda rozszerzen
            //Assert
            Assert.AreEqual(oczekiwana, aktualna);
        }
    }
}
