using System;
using System.Collections.Generic;
using System.Text;

namespace YouTubeSubscriber.Contracts
{
    public interface ISubject
    {
        void Subscribe(Subscriber sub);

        void Unsubscribe(Subscriber sub);

        void NotifySubscribers();

        void Upload(string title);
    }
}
