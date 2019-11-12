/*1.You deposit Rs 1000.00 in the bank account at 5% annual compound interest.
The interest is paid once at the end of the year.
What if you are interested in earning more than 100,000? How long will it take to reach this mark?

Sample Output:
Year Interest for the year   End of the year amount
1 	1000*0.05=50 	1050.00 
2 	1050*0.05=52.5 	1102.50 
3 	1102.50*0.05=55.125 	1157.625 
*/
//ASSIGMNET 23
using System;

namespace CompundInterest
{
    class MainInterest
    {
        int initialAmount, targetAmount;
        decimal interestRate;
        static void Main(string[] args)
        {
            {
                MainInterest mainInterestObj = new MainInterest();
                mainInterestObj.GetRelevantVariables();
                CompoundInterest compundInterestObj = new CompoundInterest();
                decimal finalAmount = compundInterestObj.FindAmountUsingCompoundInterest(mainInterestObj.initialAmount, mainInterestObj.targetAmount, mainInterestObj.interestRate);
                Console.Write("Final Amount : " + finalAmount);
                Console.ReadLine();
            }
        }

        /*Reading initial amount, target amount, rate of intrest, and period in years from user*/
        void GetRelevantVariables()
        {
            Console.Write("Enter the initial deposit amount : ");
            initialAmount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the target amount : ");
            targetAmount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Annual compound interest rate : ");
            interestRate = Convert.ToDecimal(Console.ReadLine()) / 100;
        }
    }

    class CompoundInterest
    {
        public decimal FindAmountUsingCompoundInterest(decimal depositAmount, decimal requiredAmount, decimal rateOfCompundInterest)
        {
            double time = 0;
            decimal amount = depositAmount;
            // ci=pow(intrest,time);
            decimal ci = 0;
            Console.WriteLine("Year" + "\t" + "Interest for the year " + "\t" + "End of the year amount \n");

            while (amount <= requiredAmount)

            {
                time++;
                ci = amount * rateOfCompundInterest;

                amount = amount + ci;


                Console.WriteLine(time + "\t" + amount + "*" + rateOfCompundInterest + "=" + ci + "\t\t" + amount);
                //Console.WriteLine("Your amount is : " + ci);                
            }
            return amount;
        }
    }
}

