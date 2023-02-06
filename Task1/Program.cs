using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{

    //Write a c# code to display the 1st, 2nd, 4th multiples of 7
    //which leaves a reminder of 1 when divided by 2,3,4,5 and 6
    internal class Program
    {
        public static int Gcd(int num1,int num2)
        {
            while(num2 > 0)
            {
                int r = num1 % num2;
                num1 = num2;
                num2 = r;
            }
            return num1;
        }

        public static int Lcm(int num1,int num2)
        {
            return (num1 * num2) / Gcd(num1,num2);
        }
        static void Main(string[] args)
        {
            int[] values = { 2, 3, 4, 5, 6 };
            int currentIndex = 1;
            int lcm = 1;
            foreach(var value in values)
            {
                lcm = Lcm(lcm, value);
            }
            for(int number = 1; currentIndex < 5; number += lcm)
            {
                if (number % 7 == 0) { 
                    if (currentIndex != 3)
                    {
                        Console.WriteLine(number);
                    }
                    currentIndex++;
                }
                
            }
            Console.ReadLine();

        }
    }
}
