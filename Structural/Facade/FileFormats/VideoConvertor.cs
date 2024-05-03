namespace FileFormats
{
    class VideoConvertor
    {
        public static void ConvertVideo(string fileName, FileFormat format)
        {
            switch (format)
            {
                case FileFormat.AudioMixer:
                    _ = new AudioMixer();
                    Console.WriteLine($"Call AudioMixer convert method for file {fileName}");
                    break;
                case FileFormat.BitRateReader:
                    _ = new BitRateReader();
                    Console.WriteLine($"Call BitRateReader convert method for file {fileName}");
                    break;
                case FileFormat.CodecFactory:
                    _ = new CodecFactory();
                    Console.WriteLine($"Call CodecFactory convert method for file {fileName}");
                    break;
                case FileFormat.Video:
                    _ = new VideoFile();
                    Console.WriteLine($"Call VideoFile convert method for file {fileName}");
                    break;

                default:
                    Console.WriteLine("Invalid file format");
                    break;
            }
        }
    }
}