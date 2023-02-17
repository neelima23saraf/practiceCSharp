using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceCSharp
{
    internal class callbackExample
    {
        private delegate void Sender(int i);
        private static event Sender senderObj; 
        public static void CallBAckExampleMain()
        {
            Thread t = new Thread(Func1);
            t.Start();
            senderObj = receiver;
            Console.WriteLine("Main thread completed.");
        
        }

        public static void receiver(int i)
        {
            Console.WriteLine(i);
        }

        public static void Func1()
        {
            for (int i = 0; i < 10000; i++)
            {
                Thread.Sleep(5000);
                //Console.WriteLine(i);
                senderObj(i);
            }

        }
    }   

}
