using System;

namespace inherritance
{
    public class Text : PresentationObject
    {
        public int FonSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("We added a link to" + url);
        }

    }
}
