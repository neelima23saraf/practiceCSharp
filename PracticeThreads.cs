using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceCSharp
{
    internal class PracticeThreads
    {
        public static void func1()
        {
            for (int i = 0; i < 10000; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Fucntion1");
            }
            
        }

        public static void func2()
        {
            for (int i = 0; i< 10000; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Fucntion2");
            }
        }


        public void notThreadSafeFunction()
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            for (int i = 0; i < 1000000; i++)
            {
                lock (this)
                {
                    num1 = 1;
                    num2 = 2;
                    num3 = num1 / num2;
                    num1 = 0;
                    num2 = 0;
                }
                Console.Write($"{num1} / {num2} = {num3}");
            }
        }
    }
}
