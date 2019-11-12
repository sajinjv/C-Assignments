using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//10.	Write a program in C# to generate a Fibonacci series till 40.

namespace SDET_traning
{
    class fibanocci
    {
        static void Main()
        {

            int n1 = 0, n2 = 1, n3, i, number;
            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            Console.Write("fibanocci series is ");
            Console.Write(n1 + " " + n2 + " ");    
            for (i = 2; i < number; ++i)   
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }


    }
}
  