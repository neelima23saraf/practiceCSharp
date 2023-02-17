using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceCSharp
{
    internal class refOut
    {
        public static void refOutMain()
        {

            // Assign string value
            string str = "Geek";

            // Pass as a reference parameter
            SetValue(out str);

            // Display the given string
            Console.WriteLine(str);
        }

        static void SetValue(out string str1)
        {
            str1 = "GeeksforGeeks";
            // Check parameter value
            if (str1 == "Geek")
            {
                Console.WriteLine("Hello!!Geek");
            }

            // Assign the new value
            // of the parameter
            
        }
    }
}
