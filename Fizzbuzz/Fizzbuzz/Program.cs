using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz
{
    class Program
    { // Cal made comment
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i%5==0)
                {
                    Console.WriteLine("Fizzbuzz"); //Jake's Comment-FIZZBUZZ
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);// Dave's Comment (better than Cal's)
                }
            }
            Console.ReadKey(); // Cal's comment - Stops program from ending. 
        }
    }
}
