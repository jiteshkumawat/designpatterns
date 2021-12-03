using System;
using System.Collections.Generic;
using System.Text;
using YouTubeSubscriber.Contracts;

namespace YouTubeSubscriber
{
    public class Subscriber: IObserver
    {
        public string name;
        public Channel channel = new Channel();

        public Subscriber(string name)
        {
            this.name = name;
        }

        public void Update()
        {
            Console.WriteLine("Hey " + name + ", Video Uploaded: " + channel.title);
        }

        public void SubscribeChannel(Channel channel)
        {
            this.channel = channel;
        }
    }
}
