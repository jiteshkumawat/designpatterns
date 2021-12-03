using System;
using System.Collections.Generic;
using System.Text;
using YouTubeSubscriber.Contracts;

namespace YouTubeSubscriber
{
    public class Channel: ISubject
    {
        private List<Subscriber> subscribers = new List<Subscriber>();
        public string title;

        public void Subscribe(Subscriber sub)
        {
            subscribers.Add(sub);
            sub.SubscribeChannel(this);
        }

        public void Unsubscribe(Subscriber sub)
        {
            subscribers.Remove(sub);
        }

        public void NotifySubscribers()
        {
            subscribers.ForEach(subscriber => subscriber.Update());
        }

        public void Upload(string title)
        {
            this.title = title;
            this.NotifySubscribers();
        }
    }
}
