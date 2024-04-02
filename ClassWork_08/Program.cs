using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ClassWork_08
{
    internal class Program
    {
        static Timer timer = new Timer(TimerFunction, null, int.MaxValue, int.MaxValue);
        static void Main(string[] args)
        {
            timer.Change(100, 100);

            Console.WriteLine("Press any key for exit...");
            Console.ReadLine();
        }

        static public void TimerFunction(object param)
        {
            timer.Change(int.MaxValue, int.MaxValue);
            int id = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"Time is working. Thread ID: {id}");

            Random rnd = new Random(id);
            Thread.Sleep(rnd.Next(1000, 2000));

            Console.WriteLine($"Timer is exit. Thread ID: {id}");
        
            timer.Change(100, 100);
        }
    }
}
