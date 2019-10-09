using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Math = WorkshopTestesUnitariosSquad.Math;

namespace WorkshoptestesUnitariosSquadTests
{
    [TestFixture]
    public class MathTests
    {
        Math _math;

        [SetUp]
        public void Setup()
        {
            _math = new Math();
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expected)
        {
            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
