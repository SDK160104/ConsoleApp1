using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
            static int FactorialFind(int num)     //Factorial of given number
            {
                int factorial = 1;
                for (int i = num; i >= 1; i--)
                {
                    factorial = factorial * i;
                }

                return factorial;
            }
        
        static void Main(string[] args)
        {                                                
            Console.Write("Enter your number : ");
            int num=int.Parse(Console.ReadLine());
            
            int fact = FactorialFind(num);
            Console.WriteLine($"The factorial of {num} is {fact}");
        }
    }
}
