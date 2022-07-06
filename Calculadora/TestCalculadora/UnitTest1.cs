using System;
using Xunit;
using Calculadora;

namespace TestCalculadora
{
    public class UnitTest1
    {
        Operacion calc = new Operacion(20, 5);
        [Fact]
        public void SumaTest()
        {
            calc.Op = "1";
            Assert.Equal(25, calc.resultado());
        }
        [Fact]
        public void RestaTest()
        {
            calc.Op = "2";
            calc.A = 40;
            calc.B = 2.5;
            Assert.Equal(37.5, calc.resultado());
        }
        [Fact]
        public void MultipTest()
        {
            calc.Op = "3";
            calc.A = 1.5;
            calc.B = 9;
            Assert.Equal(13.5, calc.resultado());
        }

        [Fact]
        public void DivisionTest()
        {
            calc.Op = "4";
            calc.A = 40;
            calc.B = 2;
            Assert.Equal(20, calc.resultado());
        }
        [Fact]
        public void FailingSumaTest()
        {
            calc.Op = "1";
            Assert.NotEqual(20, calc.resultado());
        }
        [Fact]
        public void FailingRestaTest()
        {
            calc.Op = "2";
            calc.A = 40;
            calc.B = 2.5;
            Assert.NotEqual(38.5, calc.resultado());
        }
        [Fact]
        public void FailingMultipTest()
        {
            calc.Op = "3";
            calc.A = 1.5;
            calc.B = 9;
            Assert.NotEqual(13, calc.resultado());
        }

        [Fact]
        public void FailingDivisionTest()
        {
            calc.Op = "4";
            calc.A = 40;
            calc.B = 2;
            Assert.NotEqual(18, calc.resultado());
        }
    }
}