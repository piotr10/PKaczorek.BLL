using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PKaczorek.BL;

namespace PKaczorek.BLTest
{
    [TestClass]
    public class ProduktRepositoryTest1
    {
        [TestMethod]
        public void pobierzProduktTest()
        {
            //Arrange
            var produktRepository = new PProduktRepository();
            var oczekiwana = new PProdukt(5)
            {
                NazwaProduktu = "klocki",
                opis = "klocki dla dziecki",
                AktualnaCena = 123.123M
            };
            
            //Act
            var aktualna = produktRepository.Pobierz(5);

            //Assert
            Assert.AreEqual(oczekiwana.ProduktId, aktualna.ProduktId);
            Assert.AreEqual(oczekiwana.NazwaProduktu, aktualna.NazwaProduktu);
            Assert.AreEqual(oczekiwana.opis, aktualna.opis);
            Assert.AreEqual(oczekiwana.AktualnaCena, aktualna.AktualnaCena);
        }
    }
}
