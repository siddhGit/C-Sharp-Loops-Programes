using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            do
            {
                Console.WriteLine(a);
                a++;
            } while (a < 20);

            Console.ReadKey();
        }
    }
}
