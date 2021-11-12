using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject;

namespace UnitTestProjectTests
{
	[TestClass]
	public class PrimeTests
	{
        private readonly PrimeService _primeService;

        public PrimeTests()
        {
            _primeService = new PrimeService();
        }

        [TestMethod]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var result = _primeService.IsPrime(1);

            Assert.IsFalse(result, $"1 should not be prime");
        }

        #region Sample_TestCode
        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        [DataRow(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.IsFalse(result, $"{value} should not be prime");
        }
        #endregion
    }
}
