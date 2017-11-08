using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab9._5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._5.Tests
{
    [TestClass()]
    public class arraycalcTests
    {
        public static double[] testitaulukko = { 1, 2, 3 };
        [TestMethod()]
        public void PlusTest()
        {
            //arraycalc Test = new arraycalc();
            
            double oikeatulos = 6;

            double tulos = arraycalcTests.testitaulukko.Sum();
            //Assert.Fail();
            Assert.AreEqual(tulos, oikeatulos);
        }

        [TestMethod()]
        public void AveTest()
        {
            double oikeatulos = 2;

            double tulos = arraycalcTests.testitaulukko.Average();
            //Assert.Fail();
            Assert.AreEqual(tulos, oikeatulos);
        }

        [TestMethod()]
        public void MinTest()
        {
            double oikeatulos = 1;

            double tulos = arraycalcTests.testitaulukko.Min();
            //Assert.Fail();
            Assert.AreEqual(tulos, oikeatulos);
        }

        [TestMethod()]
        public void MaxTest()
        {
            double oikeatulos = 3;

            double tulos = arraycalcTests.testitaulukko.Max();
            //Assert.Fail();
            Assert.AreEqual(tulos, oikeatulos);
        }
    }
}