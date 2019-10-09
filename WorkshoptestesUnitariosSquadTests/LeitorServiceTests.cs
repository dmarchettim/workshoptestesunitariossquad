using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;
using WorkshopTestesUnitariosSquad;
using WorkshopTestesUnitariosSquad.Interfaces;

//Install-Package NUnit -Version 3.8.1
//Install-Package NUnit3TestAdapter -Version 3.8.0

namespace WorkshoptestesUnitariosSquadTests
{
    [TestFixture]
    public class LeitorServiceTests
    {
        private Mock<IFileReader> _mockFileReader;
        private LeitorService _leitorService;
        
        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();
            _leitorService = new LeitorService(_mockFileReader.Object);
        }

        [Test]
        public void LerArquivoCompleto_ArquivoLido_RetornarLinhasArquivo()
        {
            string mockFileRead = "linha1,linha2";
            _mockFileReader.Setup(fr => fr.Read(It.IsAny<String>())).Returns(mockFileRead);

            var result = _leitorService.LerArquivoCompleto("caminho");

            Assert.That(result, Is.EqualTo(mockFileRead));                

        }


        [Test]
        public void LerArquivoCompleto_ArquivoInexistente_RetornarException()
        {
            _mockFileReader.Setup(fr => fr.Read(It.IsAny<String>())).Throws(new Exception("arquivo vazio")); 
            
            Assert.That(() => _leitorService.LerArquivoCompleto("caminho"), Throws.Exception);         
        }

    }
}
