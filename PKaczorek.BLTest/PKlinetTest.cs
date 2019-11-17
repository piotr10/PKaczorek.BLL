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

        [TestMethod]
        public void StaticTest()
        {
            var kl1 = new PKlient();
            kl1.Imie = "jacek";
            PKlient.licznik += 1;

            var kl2 = new PKlient();
            kl2.Imie = "maciek";
            PKlient.licznik += 1;

            var kl3 = new PKlient();
            kl3.Imie = "mkirek";
            PKlient.licznik += 1;

            Assert.AreEqual(3, PKlient.licznik);

        }

        [TestMethod]
        public void ZwalidujTest()
        {
            //arrange - przygotuj test
            PKlient klient = new PKlient();
            klient.Nazwisko = "Czerski";
            klient.Email = "piotr@wp.pl";
            var oczekiwana = true;

            //act - działaj
            var aktualna = klient.Zwaliduj();

            //assert - spr test
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void ZwalidujBrakNazwiskaTest()
        {
            //arrange - przygotuj test
            PKlient klient = new PKlient();
           
            klient.Email = "piotr@wp.pl";
            var oczekiwana = false;

            //act - działaj
            var aktualna = klient.Zwaliduj();

            //assert - spr test
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void ZwalidujBrakEmailTest()
        {
            //arrange - przygotuj test
            PKlient klient = new PKlient();
            klient.Nazwisko = "Czerski";
            
            var oczekiwana = false;

            //act - działaj
            var aktualna = klient.Zwaliduj();

            //assert - spr test
            Assert.AreEqual(oczekiwana, aktualna);
        }

        
        //arrange - przygotuj test
        //act - działaj
        //assert - spr test


    }
}
