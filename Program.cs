using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program                   //sum of array elements
    {
        static int Sum(int[] a, int len)
        {
            int total = 0;
            for (int i = 0; i < len; i++)
            {
                total += a[i];
            }
            return total;
        }

        static void Main(string[] args)
        {
            int[] a = new int[5];
            int len = a.Length;
            //Console.WriteLine(len);
            for (int i = 0; i < len; i++)
            {
                Console.Write($"Enter element no {i} :");
                a[i] = int.Parse(Console.ReadLine());
            }
            //Console.WriteLine(string.Join(",",a));    
            Console.WriteLine($"Sum of array elements:{Sum(a, len)}");
        }
    }
}
