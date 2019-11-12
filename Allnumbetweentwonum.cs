using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET_traning
{
    class Allnumbetweentwonum
    {
        static void Main()
        {
            Console.WriteLine("Enter two number");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for(int i=a;i<=b;i++)
            {
                Console.WriteLine(i);
            }


        }
    }
}
