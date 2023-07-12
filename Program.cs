using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12july_2
{
    internal class Program
    {
        enum Monthsofyear { Jan=1, Feb=2, Mar=3 };
        static void Main(string[] args)
        {

            Console.WriteLine("First Month: \t"+ (int)Monthsofyear.Jan);
            Console.WriteLine("Second Month:\t" + Monthsofyear.Feb);
                Console.ReadKey();
        }
    }
}
