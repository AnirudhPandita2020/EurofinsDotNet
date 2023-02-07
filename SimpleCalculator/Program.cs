using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using SimpleCalculator.Business;

namespace SimpleCalculator{
    internal class Program{
        static void Main(string[] args){
            int First, Second;
            Console.WriteLine("First Number: ");
            First = int.Parse(Console.ReadLine());
            Console.WriteLine("Second Number: ");
            Second = int.Parse(Console.ReadLine());
            int sum = Solver.Solve(First, Second);
            Console.WriteLine($"{First} + {Second} = {sum}");
        }
    }
}
