namespace Youtube
{
    class YoutubeCache(IYoutubeService service) : IYoutubeService
    {
        private readonly IYoutubeService _service = service;

        public void DownloadVideo(string id) => _service.DownloadVideo(id);

        public void GetVideoDetails(string id) => _service.GetVideoDetails(id);

        public void GetVideos() => _service.GetVideos();
    }
}