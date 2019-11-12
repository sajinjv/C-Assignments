/*You owe the credit card company an amount of M. The company charges you an interest of 1.5%   per month on the unpaid balance. You have decided close the card and pay off the debt by making a monthly payment of N rupee a month. 

Write a program that asks for the monthly payment, the program writes out the balance and total payments so far for every succeeding month until the balance is zero or less. 

Sample Input : 
Enter the monthly payment: 100
Sample Output: 
Month: 1 balance: 915.0 total payments: 100.0 
Month: 2 balance: 828.725 total payments: 200.0 
Month: 3 balance: 741.155875 total payments: 300.0
*/
//ASSIGNMENT 24
using System;

namespace Creditcardcompany
{
    class Program
    {
        static void Main()
        {
            Readvalues obj = new Readvalues();
            obj.read();
            obj.logic();

        }
    }
    class Readvalues
    {
        Decimal Amount;
        Decimal Amountpaid;
        decimal intrestAmount;
        decimal Intrest;
        decimal finalAmount;
        Decimal finalValue;
        public void read()
        {
            Console.WriteLine("enter the amount to be paid");
            Amount = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter the Intrest to be paid");
            Intrest = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter the amount paying");
            Amountpaid = int.Parse(Console.ReadLine());
        }
        public void logic()
        {

            int month = 0;
            decimal payement = Amountpaid;
            do
            {

                intrestAmount = (Amount * Intrest) / 100;
                finalAmount = (Amount - Amountpaid) + intrestAmount;
                //finalAmount=flag

                Amount = finalAmount;
                month++;
                finalValue = Math.Round(finalAmount, 2);
                //MessageBox.Show(dc.ToString());
                Console.WriteLine("Month: " + month + "\t" + "balance: " + finalValue + "\t" + "total payments: " + payement);
                payement = payement + Amountpaid;
            }
            while (finalAmount >= 0);
        }
    }
}
