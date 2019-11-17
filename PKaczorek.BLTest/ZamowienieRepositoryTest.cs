using System;
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
    }
}
