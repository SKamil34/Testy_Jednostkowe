using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        private readonly ObliczanieDelty _program;
        public UnitTest1()
        {
            _program = new ObliczanieDelty();
        }
        [Fact]
        public void Test1()
        {
            // arrange
            double delta = 64;
            double a = 4;
            double b = 8;
            // act
            var Test1 = ObliczanieDelty.ObliczDelte(delta, a, b);
            // assert
            Assert.Equal("Pierwiastki równania kwadratowego to: x1 = 2, x2 = -4", Test1);
        }
    }
}