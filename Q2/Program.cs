using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value of a:"+a+" Value of b:"+b);
            a = a + b; // a = 3 b = 2
            b = a - b; // b = 1 a = 3
            a = a - b;//a = 2 b = 1
            Console.WriteLine("Value of a:" + a + " Value of b:" + b);
        }
    }
}
