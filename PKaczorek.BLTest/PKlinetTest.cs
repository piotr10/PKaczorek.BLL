using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PKaczorek.BL;

namespace PKaczorek.BLTest
{
    [TestClass]
    public class PKlinetTest
    {
        [TestMethod]
        public void ImieNazwiskoTest()
        {
            // 3 etapy tworzenia testu jednostkowego :
            // 1.Arrange (przygotuj test) 
            // 2.Act (działaj)
            // 3.Assert (potwierdź test)

            //Arrange (przygotuj test)
            PKlient klient = new PKlient();
            klient.Imie = "Piotr";
            klient.Nazwisko = "Czerski";

            string oczekiwana = "Piotr, Czerski";

            //Act (działaj)
            string aktualna = klient.ImieNazwisko;
            
            //Assert (potwierdź test)
            Assert.AreEqual(oczekiwana, aktualna);

        }
        [TestMethod]
        public void ImiePusteTest()
        {
            // 3 etapy tworzenia testu jednostkowego :
            // 1.Arrange (przygotuj test) 
            // 2.Act (działaj)
            // 3.Assert (potwierdź test)

            //Arrange (przygotuj test)
            PKlient klient = new PKlient();
            klient.Nazwisko = "Czerski";

            string oczekiwana = "Czerski";

            //Act (działaj)
            string aktualna = klient.ImieNazwisko;

            //Assert (potwierdź test)
            Assert.AreEqual(oczekiwana, aktualna);

        }
        [TestMethod]
        public void NazwiskoPusteTest()
        {
            // 3 etapy tworzenia testu jednostkowego :
            // 1.Arrange (przygotuj test) 
            // 2.Act (działaj)
            // 3.Assert (potwierdź test)

            //Arrange (przygotuj test)
            PKlient klient = new PKlient();
            klient.Imie = "Piotr";
            
            string oczekiwana = "Piotr";

            //Act (działaj)
            string aktualna = klient.ImieNazwisko;

            //Assert (potwierdź test)
            Assert.AreEqual(oczekiwana, aktualna);

        }

    }
}
