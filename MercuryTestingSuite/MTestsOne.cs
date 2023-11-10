
using MercuryOne;

namespace MercuryTestingSuite
{
    public class MTestsOne
    {
        [Fact]
        public void Test1()
        {
            int a = 5;
            int b = 6;
            MercuryMethod mercuryMethod = new MercuryMethod();

            // Act
            int result = mercuryMethod.AddNumbers(a, b);

            // Assert
            Assert.Equal(11, result);
        }
    }
}