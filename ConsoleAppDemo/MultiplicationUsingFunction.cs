using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class MultiplicationUsingFunction
    {
        public static int Multiplication( int a,int b,int c)
        {
            return a*b*c;
        }
        public static void Main()
        {
            Console.WriteLine("Enter First Number");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Third Number");
            int c = int.Parse(Console.ReadLine());

            int result = a * b * c;
            Console.WriteLine($"The Multiplication of Three Numbers :{result}");
        }
    }
}
