using System;

namespace inherritance
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Hight { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object copied to clipbord.");
        }

        public void Duplicate()
        {
            Console.WriteLine("object was duplicated.");

        }
    }
}
