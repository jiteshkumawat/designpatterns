using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Observer
{
    public class LogOpenListener : IEventListener
    {
        private string fileName;

        public LogOpenListener(string fileName)
        {
            this.fileName = fileName;
        }

        public void Update(string eventType, FileStream file)
        {
            Console.WriteLine("Save to log " + fileName + ": Someone has performed " + eventType + " operation with the following file: " + file.Name);
        }
    }
}
