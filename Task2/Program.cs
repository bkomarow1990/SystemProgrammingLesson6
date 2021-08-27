using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int left, right;
            Console.WriteLine("Left: ");
            left = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Right: ");
            right = Int32.Parse(Console.ReadLine());
            Task task = Task.Run(() => {
                for (int i = left; i <= right; i++)
                {
                    Console.WriteLine(i);
                }
            });
            task.Wait();
        }
    }
}
