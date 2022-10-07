using System;

namespace ConsoleAppDemo
{
    internal class ValRefTypes
    {
        public static void Main()
        {
            Console.WriteLine("Enter the two Numbers");
            int a =  int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine((a<b) ? a : b);
            //{
            //    Console.WriteLine("The Smallest number is" + a);
            // }
            // else { 
            //   Console.WriteLine("The Smallest number is" + b);
            // }
        }
    }
}