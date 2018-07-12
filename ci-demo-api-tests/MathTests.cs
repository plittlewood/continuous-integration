
using ci_demo_api;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ci_demo_api_tests
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void When_Multiply_Result_Is4()
        {
            int numA = 2;
            int numB = 2;

            int output = MathHelper.Multiply(numA, numB);

            Assert.AreEqual(4, output);
        }

        [TestMethod]
        public void When_Multiply_Result_Is6()
        {
            int numA = 2;
            int numB = 3;

            int output = MathHelper.Multiply(numA, numB);

            Assert.AreEqual(6, output);
        }

        [TestMethod]
        public void When_Multiply_Result_Is8()
        {
            int numA = 2;
            int numB = 4;

            int output = MathHelper.Multiply(numA, numB);

            Assert.AreEqual(8, output);
        }

        [TestMethod]
        public void When_DivideBy2_Result_Is2()
        {
            int numA = 4;
            int numB = 2;

            decimal output = MathHelper.Divide(numA, numB);

            Assert.AreEqual(2, output);
        }
    }
}
