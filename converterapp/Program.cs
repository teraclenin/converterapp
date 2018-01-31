using System;

namespace converterapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("title: converter app");
            Console.WriteLine("description: converts yards to inches");
            Console.WriteLine("enter number of yards!");

            int numYards = int.Parse(Console.ReadLine());
            int numberInches = numYards * 36;

            Console.WriteLine("number of inches in " + numYards + "inches");

            Console.ReadLine();


        }
    }
}
