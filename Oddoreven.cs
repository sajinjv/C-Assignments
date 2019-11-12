using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET_traning
{
    class Oddoreven
    {
        static void Main()
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            if (num % 2==0)
            {
                Console.WriteLine("Number is even");
            }
            else
                Console.WriteLine("number is odd");
        }
    }
}
