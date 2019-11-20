using Microsoft.VisualStudio.TestTools.UnitTesting;
using PyramidMaxSumChallenge;
using UnitTestPyramidMaxSum.TestData;

namespace UnitTestPyramidMaxSum
{
    [TestClass]
    public class PyramidMaxSumTest
    {
        private PyramidMaxSum _calculator;

        [TestInitialize]
        public void Setup()
        {
            _calculator = new PyramidMaxSum();
        }

        [TestMethod]
        [TestCategory("MaxSum")]
        public void MaxSumTest()
        {
            var lines = PyramidData.TestData3Lines();
            var pyramid = InputData.CreatePyramid(lines);
            var ret = _calculator.GetMaxSum(pyramid);
            Assert.AreNotEqual(ret, 22, 0, "Should not go to left child");
            Assert.AreNotEqual(ret, 18, 0, "Should not to the smaller value");
            Assert.IsTrue(ret == 20, "Wrong result");

            lines = PyramidData.TestData4Lines();
            pyramid = InputData.CreatePyramid(lines);
            ret = _calculator.GetMaxSum(pyramid);
            Assert.IsTrue(ret == 16, "Wrong result");
            pyramid[3, 0] = 8; // 4 -->8
            ret = _calculator.GetMaxSum(pyramid);
            Assert.IsTrue(ret == 18, "Should change the route");

            pyramid[2, 0] = 0; pyramid[2, 1] = 0; pyramid[2, 2] = 0;
            ret = _calculator.GetMaxSum(pyramid);
            Assert.IsTrue(ret == 0, "Unable to reach the bottom");
            pyramid[2, 0] = 2; pyramid[2, 1] = 4; pyramid[2, 2] = 6;
            ret = _calculator.GetMaxSum(pyramid);
            Assert.IsTrue(ret == 0, "Unable to reach the bottom due to invalid line");
            
            lines = PyramidData.TestData5Lines();
            pyramid = InputData.CreatePyramid(lines);
            ret = _calculator.GetMaxSum(pyramid);
            Assert.IsTrue(ret == 23, "Should change the previous route");
            pyramid[4, 2] = 7; // 3 -->7
            ret = _calculator.GetMaxSum(pyramid);
            Assert.IsTrue(ret == 23, "Case: two valid path. Should not change the result");
        }
    }
}
