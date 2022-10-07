using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class SmallestNumber
    {
        public static int Smallest(int a ,int b)
        {
            if (a < b)
                return a;
            else
                return b;
        }
        public static void Main()
        {
            Console.WriteLine("Enter the two Numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine((a<b)?a:b);


           
        }
    }
}
