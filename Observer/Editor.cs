using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Observer
{
    public class Editor
    {
        public EventManager eventManager;

        private System.IO.FileStream file;

        public Editor()
        {
            this.eventManager = new EventManager(new string[] { "open", "save" });
        }

        public void OpenFile(string filePath)
        {
            this.file = File.OpenWrite(filePath);
            this.eventManager.Notify("open", this.file);
        }

        public void SaveFile()
        {
            if(this.file != null)
            {
                this.eventManager.Notify("save", this.file);
            }
            else
            {
                throw new Exception("No File");
            }
        }
    }
}
