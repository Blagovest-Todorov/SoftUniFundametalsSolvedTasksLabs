using System;

namespace FundametalsCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PrintNumber(int.Parse(Console.ReadLine()));

        }
        
        static void PrintNumber(int num) 
        {
            
            if (num > 0)
            {
                Console.WriteLine($"the number {num} is positive");
            }
            else if (num < 0)
            {
                Console.WriteLine($"the number {num} is negative ");
            }
            else if (num == 0)
            {
                Console.WriteLine($"the number {num} is zero ");
            }
            
        }
    }
}
