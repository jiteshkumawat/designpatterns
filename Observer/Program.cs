using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Editor editor = new Editor();
            editor.eventManager.Subscribe("open", new LogOpenListener("file"));
            editor.eventManager.Subscribe("save", new EmailNotificationListener("jitesh.kumawat@nagarro.com"));

            editor.OpenFile("sample.txt");
            editor.SaveFile();

            Console.ReadLine();
        }
    }
}
