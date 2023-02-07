using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Q9
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n = Convert.ToInt32(Console.ReadLine()); 
            for(var i = 1; i < n; i++)
            {
                if(i %2 != 0)
                 sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
