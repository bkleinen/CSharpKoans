using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KoanHelpers
{
    public class Assert
    {
        private static int _assertionCounter = 0;
        public static int AssertionCounter {
            get { return _assertionCounter; }
        }

        public static void assertThat(string message, bool shouldBeTrue)
        {
            if (shouldBeTrue) _assertionCounter++;
            else
                Console.WriteLine("Assertion failed! -: " + message);
        }
    
    }
}
