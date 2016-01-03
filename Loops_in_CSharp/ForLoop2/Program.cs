using System;
namespace ForLoop2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int n = 9;
            int s = 4, stars = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < stars; k++)
                {
                    Console.Write("*");
                }

                if (i < n / 2)
                {
                    s--;
                    stars += 2;
                }
                else
                {
                    s++;
                    stars -= 2;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
