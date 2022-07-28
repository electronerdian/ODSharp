using FibreSharp;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ODSharpTests
{
    [TestClass()]
    public class ArgCheckerTests
    {
        [DataTestMethod()]
        [DataRow(5, 1, 10)]
        [DataRow(1, 1, 10)]
        [DataRow(10, 1, 10)]
        public void Range_InBounds_DoesNotThrow(int value, int lowerBound, int upperBound)
        {
            var action = () => ArgChecker.Range(value, lowerBound, upperBound);
            action.Should().NotThrow();
        }

        [DataTestMethod()]
        [DataRow(50, 1, 10)]
        [DataRow(0, 1, 10)]
        [DataRow(11, 1, 10)]
        public void Range_OutOfBounds_Throws(int value, int lowerBound, int upperBound)
        {
            var action = () => ArgChecker.Range(value, lowerBound, upperBound);
            action.Should().Throw<ArgumentOutOfRangeException>();
        }
    }
}