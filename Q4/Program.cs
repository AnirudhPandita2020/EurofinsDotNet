using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            int value1 = Convert.ToInt32(value.Split('.')[0]);
            int value2 = Convert.ToInt32(value.Split('.')[1]);
            Console.WriteLine(value1);
            Console.WriteLine(value2);
            
        }
    }
}
