using Xunit;
using Xunit.Sdk;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ObliczDelte_Poprawnie_Zwraca_2_pierwiastki()
        {
            //arrange
            double delta = 64;
            double a = 4;
            double b = 8;

            //act
            var Test1 = ObliczanieDelty.ObliczDelte(delta, a, b);

            //assert
            Assert.NotNull(Test1);
            Assert.Equal("Pierwiastki równania kwadratowego to: x1 = 0, x2 = -2", Test1);
        }
        [Fact]
        public void ObliczDelte_Poprawnie_Zwraca_1_pierwiastek()
        {
            double delta = 0;
            double a = 1;
            double b = 4;
            var Test2 = ObliczanieDelty.ObliczDelte(delta, a, b);
            Assert.NotNull(Test2);
            Assert.Equal("Równanie kwadratowe ma jeden pierwiastek: x = -2", Test2);
        }
        [Fact]
        public void ObliczDelte_Brak_Pierwiastkow()
        {
            double delta = -139;
            double a = -1;
            double b = -1;
            var Test3 = ObliczanieDelty.ObliczDelte(delta, a, b);
            Assert.NotNull(Test3);
            Assert.Equal("Równanie kwadratowe nie ma pierwiastków rzeczywistych.", Test3);
        }
        [Theory]
        [InlineData(0,1,4)]
        public void Zwraca_Teorie(double delta, double a, double b) 
        {
            var Test4 = ObliczanieDelty.ObliczDelte(delta, a, b);
            Assert.NotNull(Test4);
            Assert.Equal("Równanie kwadratowe ma jeden pierwiastek: x = -2", Test4);
        }
    }
}