using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WorkshopTestesUnitariosSquad;
using Moq;

namespace WorkshoptestesUnitariosSquadTests
{
    [TestFixture]
    public class ObjetoQualquerTests
    {
        private Mock<IOutroObjetoQualquer> _mockObjetoQualquer;
        ObjetoQualquer _objetoQualquer;

        [SetUp]
        public void Setup()
        {
            _mockObjetoQualquer = new Mock<IOutroObjetoQualquer>();
            _objetoQualquer = new ObjetoQualquer(_mockObjetoQualquer.Object);
        }

        [Test]
        public void UmMetodoQualquer_WhenCalled_PrintConsoleLog()
        {
            _objetoQualquer.UmMetodoQualquer();

            _mockObjetoQualquer.Verify(t => t.outroMetodoQualquer());
        }
    }
}
