using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Principal, Rate;
            int Time;

            Console.WriteLine("Enter Principal Amount:");
            Principal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Rate of interest:");
            Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Time period");
            Time = Convert.ToInt32(Console.ReadLine());
        }
    }
}
