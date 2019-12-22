using NUnit.Framework;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
    public class Test
    {
        [TestCase("50-20", 30)]
        [TestCase("40/10", 4)]
        [TestCase("40+14", 44)]
        [TestCase("0*10", 0)]
        [TestCase("2*10", 20)]
        public void CalculatorHasCorrectReturnValue(string input, long expectedResult)
        {
            var returnValue = Calculator.Calculate(input);

            Assert.IsTrue(returnValue.GetType() == typeof(long));
            Assert.IsTrue(returnValue == expectedResult);
        }
    }
}