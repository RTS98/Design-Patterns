namespace Youtube
{
    class YoutubeService : IYoutubeService
    {
        public void DownloadVideo(string id) => Console.WriteLine($"Downloading video {id}");

        public void GetVideoDetails(string id) => Console.WriteLine($"Fetching video {id} details");

        public void GetVideos() => Console.WriteLine("Fetching all videos");
    }
}