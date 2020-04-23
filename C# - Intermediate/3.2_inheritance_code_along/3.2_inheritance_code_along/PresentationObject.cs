using System;

namespace _3._2_inheritance_code_along
{
    public class PresentationObject
    {
        public int Width { get; set; }  // prop
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object copied to clipboard.");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated.");
        }
    }
}
