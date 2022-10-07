using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class arrList
    {
        private static object count;

        public static void Main()
        {
            var names = new List<String> { "Arun", "vinay", "kiran" };

            foreach (var name in names)
                Console.WriteLine($"hello {name.ToUpper()}");
            
        }
    }
}
