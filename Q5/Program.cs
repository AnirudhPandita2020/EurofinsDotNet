using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Student name");
            name = Console.ReadLine();
            Console.WriteLine("Marks in 3 subject");
            float marks1, marks2, marks3;
            marks1 = float.Parse(Console.ReadLine());
            marks2 = float.Parse(Console.ReadLine());
            marks3 = float.Parse(Console.ReadLine());
            float average = (marks1 + marks2 + marks3) / 3;
            float total = (marks1 + marks2 + marks3);
            Console.WriteLine("Average:"+average);
            Console.WriteLine("Total:"+total);
            if (average >= 60)
            {
                Console.WriteLine("Pass 1st class");
            }
            else if (average >= 50 && average <= 59)
            {
                Console.WriteLine("Pass 2nd class");
            }
            else if (average <= 49 && average >= 35)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
