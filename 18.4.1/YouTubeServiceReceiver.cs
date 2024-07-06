using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._4._1
{
    public class YouTubeServiceReceiver
    {
        public string adress;
        public YouTubeServiceReceiver(string adress)
        {
        this.adress = adress;
        }

        public void Operation()
        {
            Console.WriteLine("Процесс запущен");
        }
    }
}
