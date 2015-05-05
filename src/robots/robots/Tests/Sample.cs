using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace RobotTests
{
    [TestFixture]
    public class Sample
    {
        [Test]
        public void PositiveTest()
        {
            int x = 7;
            int y = 7;

            Assert.AreEqual(x, y);
        }

        [Test, ExpectedException(typeof(NotSupportedException))]
        public void ExectedExceptionTest()
        {
            throw new NotSupportedException();
        }

    }
}
