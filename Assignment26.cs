﻿/*Write a program to create a list of words present in a sentence passed from command line. The list also contain count of the appearance of each word in that sentence. The program has to display the word and its frequency. 
Sample Input: “DotNet is technology and DotNet is interoperable and DotNet is simple”.
Sample Output: DotNet -  3
		Is – 3 and so on...
*/
//ASSIGNEMNT 26
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRepeatedWordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string Word;
            Console.WriteLine("Enter the word!..");
            Word = Console.ReadLine();   // Read the Input string from User at Run Time  
            var Value = Word.Split(' ');  // Split the string using 'Space' and stored it an var variable  
            Dictionary<string, int> RepeatedWordCount = new Dictionary<string, int>();
            for (int i = 0; i < Value.Length; i++) //loop the splited string  
            {
                if (RepeatedWordCount.ContainsKey(Value[i])) // Check if word already exist in dictionary update the count  
                {
                    int value = RepeatedWordCount[Value[i]];
                    RepeatedWordCount[Value[i]] = value + 1;
                }
                else
                {
                    RepeatedWordCount.Add(Value[i], 1);  // if a string is repeated and not added in dictionary , here we are adding   
                }
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Repeated words and counts");
            foreach (KeyValuePair<string, int> kvp in RepeatedWordCount)
            {
                Console.WriteLine(kvp.Key + " Counts are " + kvp.Value);  // Print the Repeated word and its count  
            }
            Console.ReadKey();
        }
    }
}




