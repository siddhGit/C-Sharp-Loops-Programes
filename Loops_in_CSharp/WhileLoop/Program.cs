

// Programe to reverse a number..
using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int rem, value = 0;
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                rem = n % 10;
                value = (value * 10) + rem;
                n = n / 10;
            }
            Console.WriteLine("Reverse is {0}",value);
            Console.ReadKey();
        }
        
    }
}
