using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceCSharp
{
    internal class paramParameter
    {
        public static int Add(params int[] ListNumbers)
        {
            int total = 0;

            // foreach loop
            foreach (int i in ListNumbers)
            {
                total += i;
            }
            return total;
        }

        // Driver Code    
       public static void ParamMain()
        {
            try 
            {
                // Calling function by passing 5
                // arguments as follows
                int y = Add(12, 13, 10, 15, 56);

                // Displaying result
                Console.WriteLine(y);
            } 
            catch  {
                
            }
            finally { Console.WriteLine("finallu called."); }
            
 
        }
    }
}

