using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class age
    {
        public static void Main()
        {
            Console.WriteLine("Enter your age ");
            int age = int.Parse(Console.ReadLine());

            int myAge = age + 10;

            Console.WriteLine("Your age after 10 yeras is" + myAge);
        }

    }
}
