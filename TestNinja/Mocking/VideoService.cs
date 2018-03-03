using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace TestNinja.Mocking
{
    public class VideoService
    {
        private IVideoRepository _repo;
        private IFileReader _fileReader;
        
        public VideoService(IFileReader reader = null,IVideoRepository videos = null)
        {
            _fileReader = reader ?? new FileReader();
            _repo = videos ?? new VideoRepository();
        }
        
        public string ReadVideoTitle()
        {
            var str = _fileReader.ReadAllText("video.txt");
//            var video = JsonConvert.DeserializeObject<Video>(str);
//            if (video == null)
//                return "Error parsing the video.";
            return str;
        }


        public string GetUnprocessedVideosAsCsv()
        {
            
            var videoIds = new List<int>();
            var videos = _repo.Videos();
            foreach (var v in videos)
            {
                videoIds.Add(v.Id);
            }

            
            return String.Join(",", videoIds);
            
        }
    }

    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsProcessed { get; set; }
    }

    public class VideoContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
    }
}