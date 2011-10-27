using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheKoans;
using KoanHelpers;

namespace CSharpKoans
{
    class Program
    {
        static void Main(string[] args)
        {
            AboutTimsSlides.Run();
            AboutAttributes.Run();
            AboutXXX.Run();
            AboutCloning.Run();
            AboutGeneric.Run();
            Console.WriteLine("Finished. Successful assertions: " + Assert.AssertionCounter);
            Console.ReadKey(); // just to keep the window open
        }
    }
}
