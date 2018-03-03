using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

namespace NinjaTest
{    
    [TestFixture]
    public class VideoServiceTests
    {
        private VideoService _videoService;
        private Mock<IFileReader> _fileReader;
        private Mock<IVideoRepository> _repository;

        [SetUp]
        public void Setup()
        {
         
            _fileReader = new Mock<IFileReader>();
            _repository = new Mock<IVideoRepository>();
            _videoService = new VideoService(_fileReader.Object, _repository.Object);

        }
        
        [Test]
        public void ReadVideoTitle_VideoNull_ReturnErrorMessage()
        {
            
        }
        
        [Test]
        public void ReadVideoTitle_TitleReturned_ShowString()
        {
            _fileReader.Setup(fr => fr.ReadAllText("video.txt")).Returns("");
            
            var result = _videoService.ReadVideoTitle();
            
            Assert.That(result, Is.EqualTo(""));
        }
            
        [Test]
        public void GetUnprocessedVideo_AllProcessed_EmptyString()
        {
            _repository.Setup(r => r.Videos()).Returns(new List<Video>
            {
                new Video { Id = 1 },
                new Video { Id = 2 },
                new Video { Id = 3 },
            });
            
            var result = _videoService.GetUnprocessedVideosAsCsv();
            
            Assert.That(result, Is.EqualTo("1,2,3"));
        }
    }

}