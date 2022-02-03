using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestCurves;

namespace TestCompute.UnitTest
{
    [TestClass]
    public class Curves
    {
        [TestMethod]
        public void CompareCurves()
        {
            var obj = new CurveTests();

            Assert.IsTrue(obj.CompareCurves());
        }
    }
}
