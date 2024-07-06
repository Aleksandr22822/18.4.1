using YoutubeExplode;

namespace _18._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            YouTubeServiceReceiver youTubeServiceReceiver = new YouTubeServiceReceiver("https://www.youtube.com/watch?v=cg32kTwXEiw");
            YoutubeClient youtubeClient = new YoutubeClient();
            User user = new User();
            CommandForShow commandForShow = new CommandForShow(youTubeServiceReceiver, youtubeClient);
            user.SerCommand(commandForShow);
            user.Run();
            Console.ReadKey();  
            CommandForDownload commandForDownload = new CommandForDownload(youTubeServiceReceiver, youtubeClient);
            user.SerCommand(commandForDownload);
            user.Run();
            Console.ReadKey();
        }
    }
}
