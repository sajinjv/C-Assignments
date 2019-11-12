using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*16.	Write a program in C# to accept ten marks and display the following
a.Total
b.Average
c.Minimum marks
d.Maximum marks
e.Display marks in ascending order
f.Display marks in descending order
*/

namespace SDET_traning
{
    class acceptmark
    {
        static void Main()
        {
        int[] mark = new int[15];
        int sum = 0;
        float avg = 0.0f;
        int temp = 0;
        int i = 0;
        int j = 0;
        int c = 10;
        Console.Write("Enter ten Mark"); 
                                 
                                 for(i=0;i<10;i++)
                                {
                                                mark[i]=Convert.ToInt32(Console.ReadLine());
                                }
                                  for(i=0;i<10;i++)
                                {
                                                sum=sum+mark[i];
                                                
                                 }
Console.Write("Total is "+sum+"\n");
                                avg=(sum/c);
                                Console.Write("Average is "+avg+"\n");
                                
                                 for(i=0;i<10;i++)
                                {
                                                for (j=i+1;j<10;j++)
                                                {
                                                                if (mark[i] > mark[j])   
                {  
                    temp = mark[i];  
                    mark[i] = mark[j];  
                    mark[j] = temp; }
                                }
                                }
                                Console.Write("marks in descending order\n");
                                for(i=0;i<10;i++)
                                {
                                                
                                                 Console.Write(mark[i]+"\n");
                                                
                                }
                                
                                Console.Write("Minimum marks is "+mark[0]+"\n");
                                  for(i=0;i<10;i++)
                                {
                                                for (j=i+1;j<10;j++)
                                                {
                                                                if (mark[i] < mark[j])   
                {  
                    temp = mark[i];  
                    mark[i] = mark[j];  
                    mark[j] = temp; }
                                }
                                }
                                Console.Write("Maximum marks is "+mark[0]+"\n");
                                
                                 Console.Write("marks in ascending order\n");
                                for(i=0;i<10;i++)
                                {
                                                
                                                Console.Write(mark[i]+"\n");
                                                
                                }
                                
                 }
  }

    }

