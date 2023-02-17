using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace practiceCSharp
{
    internal class AsyncAwait
    {
        public static async void AsyncAwaitMain()
        {
             await Task.Run(() => { Thread.Sleep(20000); });
             
            
            Console.WriteLine("Task has completed");
        }


        public static void TaskInitiation()
        {
            Action<object> action = (object obj) => {
                Console.WriteLine("Task={0}, obj={1}, Thread={2}",
                                   Task.CurrentId, obj,
                                   Thread.CurrentThread.ManagedThreadId);
            };

            Task t1 = new Task(action, "aplha");
            
            Task t2 = Task.Factory.StartNew(action, "beta");
            t2.Wait();

            t1.Start();
            Console.WriteLine("t1 has been launched. (Main Thread={0})",
                  Thread.CurrentThread.ManagedThreadId);
            
            t1.Wait();

            String taskData = "delta";
            Task t3 = Task.Run(() =>
            {
                Console.WriteLine("Task={0}, obj={1}, Thread={2}",
                                                         Task.CurrentId, taskData,
                                                          Thread.CurrentThread.ManagedThreadId);
            });

            t3.Wait();
            // Construct an unstarted task
            Task t4 = new Task(action, "gamma");
            // Run it synchronously
            t4.RunSynchronously();
            // Although the task was run synchronously, it is a good practice
            // to wait for it in the event exceptions were thrown by the task.
            t4.Wait();
        }


        public static void TaskExecution() {

            Task.Run(() => {
                int count = 0;
                for (count =0; count <= 1000000; count++)
                {}
                Console.WriteLine("Finished {0} loop iterations",
                                                    count);
            
            });
        

            Task t1 = new Task(() => { });
            waitForMe(t1);

        }

        public static void waitForMe(Task t1)
        {
            t1.Wait(10000);
            Console.WriteLine("HI");
        }
    }
}
