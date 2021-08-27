using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Print(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 5, 4, 5, 7, 6, 7, 8, 9, 10 };
            Task task1 = new Task(() =>
            {
                arr = arr.Distinct().ToArray();
                Print(arr);
            });
            task1.Start();
            task1.Wait();
            Task task2 = task1.ContinueWith((el) => { arr = arr.OrderBy(i => i).ToArray(); Print(arr); });

            Task task3 = task2.ContinueWith((el) => { Console.WriteLine(Array.BinarySearch(arr, 2)); });
            Console.ReadKey();

        }
    }
}
