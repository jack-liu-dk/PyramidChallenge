using Microsoft.VisualStudio.TestTools.UnitTesting;
using PyramidMaxSumChallenge;
using UnitTestPyramidMaxSum.TestData;

namespace UnitTestPyramidMaxSum
{
    [TestClass]
    public class InputDataTest
    {
        private PyramidMaxSum _calculator;

        [TestInitialize]
        public void Setup()
        {
            _calculator = new PyramidMaxSum();
        }

        [TestMethod]
        [TestCategory("Pyramid Data Validation")]
        public void InputDataTestSmall()
        {
            var pyramid = InputData.CreatePyramid();
            // Assert.IsNotNull(lines, "Failed to validate the input data (null)!");

            var length = pyramid.GetLength(0);
            var width = pyramid.GetLength(1);
            Assert.IsTrue(length == width, "Input data invalid! It must has same length and width.");
            for (int i = length - 1; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Assert.IsTrue(pyramid[i, j] != 0, $"Input data contains invalid node ({i}, {j})");
                }
            }
        }
    }
}
