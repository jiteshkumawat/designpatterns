using System;
using System.Collections.Generic;
using System.Text;

namespace YouTubeSubscriber.Contracts
{
    public interface IObserver
    {
        void Update();

        void SubscribeChannel(Channel channel);
    }
}
