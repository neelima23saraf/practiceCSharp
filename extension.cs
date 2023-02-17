using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace practiceCSharp
{
    internal static class extension
    {
        public static void extensionMain() {

            int a = 1;
            int b = 2;
            bool c = a.compareInt(b);

            Console.WriteLine(c);

        }

        public static bool compareInt(this int a, int b) {
            
            return a > b;
        }
    }
}
