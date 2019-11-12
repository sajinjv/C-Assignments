﻿/*2. Write a program in C# Sharp for a 2D array of size 3x3 and print the matrix.*/
//ASSIGMNET 23
using System;

namespace matrix
{
    class matrix
    {
        public static void Main(string[] args)
        {
            matrix read = new matrix();
            read.readmatrix();
        }
        void readmatrix()
        {
            int i, j;
            int[,] arr1 = new int[3, 3];

            Console.Write("\n\nRead a 2D array of size 3x3 and print the matrix :\n");
            Console.Write("------------------------------------------------------\n");


            /* Stored values into the array*/
            Console.Write("Input elements in the matrix :\n");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("\nThe matrix is : \n");
            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }
            Console.Write("\n\n");
        }
    }
}

