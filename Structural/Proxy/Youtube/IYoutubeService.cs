namespace Youtube
{
    interface IYoutubeService
    {
        void GetVideos();
        void GetVideoDetails(string id);
        void DownloadVideo(string id);
    }
}