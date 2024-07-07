using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;

namespace _18._4._1
{
    interface ICommand
    {

        void Run();
    }

    class CommandForShow : ICommand
    {
        YouTubeServiceReceiver youTubeServiceReceiver;
        YoutubeClient youtubeClient;

        public CommandForShow(YouTubeServiceReceiver youTubeServiceReceiver, YoutubeClient youtubeClient)
        {
            this.youTubeServiceReceiver = youTubeServiceReceiver;
            this.youtubeClient = youtubeClient;
        }

        public async void Run()
        {
            YoutubeExplode.Videos.Video videoInfo = await youtubeClient.Videos.GetAsync(youTubeServiceReceiver.adress);
            Console.WriteLine(videoInfo.Title);
            Console.WriteLine($"Продолжительность: {videoInfo.Duration}");
            Console.WriteLine($"Автор: {videoInfo.Author}");
            Console.WriteLine($"Описание: {videoInfo.Description}");
        }
    }

    class CommandForDownload: ICommand
    {
        YouTubeServiceReceiver youTubeServiceReceiver;
        YoutubeClient youtubeClient;

        public CommandForDownload(YouTubeServiceReceiver youTubeServiceReceiver, YoutubeClient youtubeClient)
        {
            this.youTubeServiceReceiver = youTubeServiceReceiver;
            this.youtubeClient = youtubeClient;
        }

        public async void Run()
        {
            var streamManifest = await youtubeClient.Videos.Streams.GetManifestAsync(youTubeServiceReceiver.adress);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
            await youtubeClient.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");
        }
    }
    
        
    
}
