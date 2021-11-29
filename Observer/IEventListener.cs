using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Observer
{
    public interface IEventListener
    {
        void Update(string eventType, FileStream file);
    }
}
