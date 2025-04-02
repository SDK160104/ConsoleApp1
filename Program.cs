using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program                   //find the spaces of the given string
    {
        public static int Space(string s)
        {
            int spc = 0;
            for(int i = 0; i < s.Length; i++)
            {
                string s1 = s.Substring(i, 1);
                if(s1==" ")
                {
                    spc++;
                }
            }
           return spc;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your String :");
            string s = Console.ReadLine();
            int num = Space(s);
            Console.WriteLine($"the {s} have {num} spaces");
        }
    }
}
