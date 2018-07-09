
using ci_demo_api;
using Xunit;

namespace ci_demo_api_tests
{
    public class MathTests
    {
        [Fact]
        public void When_Multiply_Result_Is4()
        {
            int numA = 2;
            int numB = 2;

            int output = MathHelper.Multiply(numA, numB);

            Assert.Equal(4, output);
        }

        [Fact]
        public void When_Multiply_Result_Is6()
        {
            int numA = 2;
            int numB = 3;

            int output = MathHelper.Multiply(numA, numB);

            Assert.Equal(6, output);
        }

        [Fact]
        public void When_Multiply_Result_Is8()
        {
            int numA = 2;
            int numB = 4;

            int output = MathHelper.Multiply(numA, numB);

            Assert.Equal(8, output);
        }

        [Fact]
        public void When_DivideBy2_Result_Is2()
        {
            int numA = 4;
            int numB = 2;

            decimal output = MathHelper.Divide(numA, numB);

            Assert.Equal(2, output);
        }
    }
}
