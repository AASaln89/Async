using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            SumAsync(a);
            Console.ReadKey();
        }
        static void Sum(int a)
        {
            int result = 1;
            for (int i = 1; i < a; i++)
            {
                result *= i;
                Thread.Sleep(5);
            }
            Console.WriteLine("Резудьтат");
            Console.WriteLine(result);
        }
        static async void SumAsync(int a)
        {
            await Task.Run(() => Sum(a));
        }

    }
}