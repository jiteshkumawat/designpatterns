using System;

namespace YouTubeSubscriber
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel demo = new Channel();
            Subscriber s1 = new Subscriber("Jitesh");
            Subscriber s2 = new Subscriber("Neha");
            Subscriber s3 = new Subscriber("Harsh");
            Subscriber s4 = new Subscriber("Diljeet");
            Subscriber s5 = new Subscriber("Dipendra");

            demo.Subscribe(s1);
            demo.Subscribe(s2);
            demo.Subscribe(s3);
            demo.Subscribe(s4);
            demo.Subscribe(s5);

            demo.Unsubscribe(s3);

            //s1.SubscribeChannel(demo);
            //s2.SubscribeChannel(demo);
            //s3.SubscribeChannel(demo);
            //s4.SubscribeChannel(demo);
            //s5.SubscribeChannel(demo);

            demo.Upload("Learn Observer Pattern");

            demo.Upload("Learn Pattern");

            Console.ReadLine();
        }
    }
}
