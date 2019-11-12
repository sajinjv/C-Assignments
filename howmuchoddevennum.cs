using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET_traning
{
    class howmuchoddevennum
    {
        static void Main()
        {
            int even =0;
            int a=0;
            int b=0;
            int odd=0;
           
            // Console.WriteLine("enter the numbers");
            Console.WriteLine("enter the numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            for (; num1 <= num2; num1++) 
            {                    
                if (num1%2==0)
                {
                    //int a;
                    even = ++a;
                }
                else
                {
                    odd = ++b;
                }                
            }
            Console.WriteLine("Total Number of even number = " + even);
            Console.WriteLine("Total Number of odd number = " + odd);
        }
    }
}
