using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Principal, Rate, Time;
            Console.WriteLine("Enter principal amount");
            Principal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Rate");
            Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Time");
            Time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Simple interest for the above:");
            float interest = (Principal * Rate * Time) / 100;
            Console.WriteLine(interest);
        }
    }
}
