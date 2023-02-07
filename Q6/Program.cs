using System;
using System.Collections.Generic;
using System.Linq;


namespace Q6
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').ToList().ConvertAll(x => int.Parse(x));
            list.Sort((x, y) => y.CompareTo(x));
            Console.WriteLine("First biggest number:" + list[0]) ;
            Console.WriteLine("Second bigger number: " + list[1]);
         
           
        }
    }
}
