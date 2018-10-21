using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UlamekLib;

namespace UnitTestProjectUlamek
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void KonstruktorDoyslny_LicznikZero()
        {
            //AAA
            //Arrange
            var u = new Ulamek();
            //Act

            //Assert
            Assert.AreEqual(0, u.Licznik);
            Assert.AreEqual(1, u.Mianownik);

        }

        [DataTestMethod]
        [DataRow(1 ,2 ,1, 2)]
        [DataRow(-3, 2, -3, 2)]
        [DataRow(0, 2, 0, 1)]
        //[DataRow(1, 2, 1, 2)]
        public void KonstruktorDwuargumentowy_OK(long l, long m,long ul, long um)
        {
            //AAA
            //Arrange
            var u = new Ulamek(l,m);
            //Act

            //Assert
            Assert.AreEqual(ul, u.Licznik);
            Assert.AreEqual(um, u.Mianownik);

        }

        [DataTestMethod]
        [DataRow(1, 2, 1, 2)]
        [DataRow(-3, 2, -3, 2)]
        [DataRow(3, -2, -3, 2)]
        [DataRow(-3, -2, 3, 2)]
        public void KonstruktorDwuargumentowy_znakWLiczniku(long l, long m, long ul, long um)
        {
            //AAA
            //Arrange
            var u = new Ulamek(l, m);
            //Act

            //Assert
            Assert.AreEqual(ul, u.Licznik);
            Assert.AreEqual(um, u.Mianownik);
            Assert.IsTrue(u.Mianownik > 0);
            Assert.IsTrue(Math.Sign(l*m) == Math.Sign(u.Licznik*u.Mianownik));
        }

        [DataTestMethod]
        [DataRow(2, 4, 1, 2)]
        [DataRow(-12, 8, -3, 2)]
        [DataRow(9, -3, -3, 1)]
        [DataRow(0, -2, 0, 1)]
        public void KonstruktorDwuargumentowy_upraszczanie(long l, long m, long ul, long um)
        {
            //AAA
            //Arrange
            var u = new Ulamek(l, m);
            //Act

            //Assert
            Assert.AreEqual(ul, u.Licznik);
            Assert.AreEqual(um, u.Mianownik);
            Assert.IsTrue(u.Mianownik > 0);
            Assert.IsTrue(Math.Sign(l * m) == Math.Sign(u.Licznik * u.Mianownik));






        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Konstruktor_zerowyMianownik()
        {
            var u = new Ulamek(5, 0);
        }










    }
}
