using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//10.	Write a program in C# to generate a Fibonacci series till 40.

namespace SDET_traning
{
    class factorialofanumber
    {
       static void Main()
        {
            int number = 1;
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                 number = number * i;
            }
            Console.WriteLine("factorial is: " + number);
        }
        
    }
}
