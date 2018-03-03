using System.Net;
using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

namespace NinjaTest
{    
    [TestFixture]
    public class InstallerHelperTest
    {
        private InstallerHelper _installerHelper;
        private Mock<IFileDownloader> _downloadInstaller;

        [SetUp]
        public void Setup()
        {
            _downloadInstaller = new Mock<IFileDownloader>();
            _installerHelper = new InstallerHelper(_downloadInstaller.Object);
        }
        
        [Test]
        public void DownloadInstaller_DownloadFails_ReturnFalse()
        {
            _downloadInstaller.Setup(fd => 
                    fd.DownloadFile(It.IsAny<string>(), It.IsAny<string>()))
                .Throws<WebException>();

            var result = _installerHelper.DownloadInstaller("customer", "installer");
            
            Assert.That(result, Is.False);
        }

        [Test]
        public void DownloadInstaller_DownloadCompletes_ReturnTrue()
        {
            var result = _installerHelper.DownloadInstaller("customer", "installer");
            
            Assert.That(result, Is.True);
        }
    }
}