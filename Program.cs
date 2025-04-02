using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program                  //small calculator app 
    {
       static void Add(int a,int b)
        {
            int total = a + b;
            Console.WriteLine($"The addition of {a}+{b} is {total} ");
        }
        static int Sub(int a,int b)
        {
            int total = a - b;
            return total;
        }
        static void Mul(ref int a,ref int b)
        {
            int total = a * b;
            Console.WriteLine($"the multiplication of {a}*{b} is {total}");
        }
        static int Div(ref int a,ref int b) {
            int total = a / b;
            return total;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome my calculator app!");
            bool br = true;
            while (br)
            {
                Console.WriteLine("Choose the option \n1.Addtion 2.Subtraction 3.multiplication 4.division 5.Exit");
                int value = int.Parse(Console.ReadLine());
                if (value <5) {
                    Console.Write("Enter your first no: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Enter your second no: ");
                    int b = int.Parse(Console.ReadLine());

                    switch (value)
                    {
                        case 1:
                            Add(a, b);
                            break;
                        case 2:
                            int total = Sub(a, b);
                            Console.WriteLine($"the subtraction of {a}-{b} is {total}");
                            break;
                        case 3:
                            Mul(ref a, ref b);
                            break;
                        case 4:
                            int div = Div(ref a, ref b);
                            Console.WriteLine($"the division of {a}/{b} is {div}");
                            break;  
                    }

                }
                else if (value==5)
                {
                    Console.WriteLine("Thank you for using calculator !");
                    br = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter the correct option ! ");
                    br = true;

                }

            }
        }
    }
}
