using NUnit.Framework;
using csdemo.Utils;

namespace csdemo.tests.Utils
{

    [TestFixture]
    public class FibonacciTests
    {

        [Test]
        public void testFib()
        {
            Fibonacci f = new Fibonacci();
            Assert.AreEqual(f.calculate(1),1);
            Assert.AreEqual(f.calculate(8),21);
        }
    }
}