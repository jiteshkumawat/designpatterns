using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Observer
{
    public class EventManager
    {
        Dictionary<string, List<IEventListener>> listeners;

        public EventManager(string[] operations)
        {
            this.listeners = new Dictionary<string, List<IEventListener>>();

            foreach (string operation in operations)
            {
                this.listeners.Add(operation, new List<IEventListener>());
            }
        }

        public void Subscribe(string eventType, IEventListener handler)
        {
            var listener = this.listeners[eventType];
            listener.Add(handler);
        }

        public void Unsubscribe(string eventType, IEventListener handler)
        {
            var listener = this.listeners[eventType];
            listener.Remove(handler);
        }

        public void Notify(String eventType, FileStream file)
        {
            List<IEventListener> users = this.listeners[eventType];
            foreach (IEventListener listener in users)
            {
                listener.Update(eventType, file);
            }
        }
    }
}
