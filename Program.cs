using System;
using System.Threading;

namespace HouseSaversApplication
{
    class HouseSaversProgram
    {

        static void Main(string[] args)
        {
            #region Variables
            string name;
            double priceOfHouse;
            double downPaymentPercent;
            double monthlyIncome;
            double monthlyExpenses;
            double downPaymentPercentTotal;
            double monthlyMaxSavingsTotal;
            #endregion

            // Greeting and ask name
            Console.Write("\nHello there.");
            Thread.Sleep(1000);
            Console.WriteLine("\nWhat is your name? ");
            //Gets input from the Console and stores to variable.
            name = Console.ReadLine();

            //Prints out name input by user and continue greeting.
            Console.WriteLine("\n" + name + ", thank you for using HouseSavers. \n");
            Thread.Sleep(2000);

            Console.WriteLine("This application will give you the \ntotal down payment amount \nrequired to save up for a house.\n");
            Thread.Sleep(2000);

            Console.WriteLine("We just have a few questions for you to answer.");
            Thread.Sleep(2000);

            //Get price of house
            Console.WriteLine("What is the price of the house?  ");
            priceOfHouse = Convert.ToDouble(Console.ReadLine());

            //Get down payment percent
            Console.WriteLine("\nWhat is the down payment percent required?");
            downPaymentPercent = Convert.ToDouble(Console.ReadLine());

            //Convert whole number to decimal for calculations
            downPaymentPercent = DownPaymentPercent(downPaymentPercent);

            Thread.Sleep(3000);

            //Tell user there are a couple questions left to answer
            Console.WriteLine("\nGreat! Just a couple more questions left. \n\n");
            Thread.Sleep(2000);

            //Get monthly income
            Console.WriteLine("What is your total monthly income? ");
            monthlyIncome = Convert.ToDouble(Console.ReadLine());

            //Get monthly expenses
            Console.WriteLine("\nHow much are your total monthly expenses? ");
            monthlyExpenses = Convert.ToDouble(Console.ReadLine());

            Thread.Sleep(2000);

            //Thank user and tell user the application is calculating
            Console.WriteLine("\nThank you for that information! ");
            Thread.Sleep(1000);

            Console.WriteLine("\n\nCalculating total down payment amount...");
            //Calculate down payment percentage total
            downPaymentPercentTotal = priceOfHouse * downPaymentPercent;
            Thread.Sleep(3000);

            Console.WriteLine("\nCalculating total monthly savings...");
            //Calculate monthly maximum savings total
            monthlyMaxSavingsTotal = monthlyIncome - monthlyExpenses;
            Thread.Sleep(3000);

            //Results
            Console.WriteLine("The total down payment amount is: " + downPaymentPercentTotal);
            Console.WriteLine("Your maximum total monthly savings possible is: " + monthlyMaxSavingsTotal);
        }

        private static double DownPaymentPercent(double downPaymentPercent)
        {
            return downPaymentPercent / 100;
        }

        //TODO: Create methods for downPaymentPercentTotal and monthlyMaxSavingsTotal.
    }
}
