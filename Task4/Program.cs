using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Task[] tasks = new Task[4];
            tasks[0] = Task.Run(()=> {
                Console.WriteLine($"Min: {arr.Min()}");
            });
            tasks[1] = Task.Run(() => {
                Console.WriteLine($"Max: {arr.Max()}");
            });
            tasks[2] = Task.Run(() => {
                Console.WriteLine($"Avg: {arr.Average()}");
            });
            tasks[3] = Task.Run(() => {
                Console.WriteLine($"Summ: {arr.Sum()}");
            });
            Console.ReadKey();
        }
    }
}
