using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceCSharp
{
    internal class OOPS
    {
        public static void oopsMain()
        {
            parent p = new parent();
            p.display();
            child c = new child();
            c.display();

            parent p1 = new child();
            p1.display();

        }
    }

    internal class parent {
        internal virtual void display()
        {
            Console.WriteLine("Hello Parent");
        }
    }

    internal class child : parent {

        internal new void display()
        { Console.WriteLine("HEllo form child"); }
    }
}
