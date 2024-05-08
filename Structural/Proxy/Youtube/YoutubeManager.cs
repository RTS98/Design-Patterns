namespace Youtube
{
    class YoutubeManager(IYoutubeService service)
    {
        private readonly IYoutubeService _service = service;

        public void DownloadVideo(string id) => _service.DownloadVideo(id);
    }
}