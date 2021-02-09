using System;
/*This is the same as the python value checker but done in C#:
  This program will be used to calculate the value, in dollars per hour, of every subscription you have.
  It will prompt you for the name of each subscription you have, then the cost for LAST MONTH, then the time
  you spent using it LAST MONTH.
  
  In the future I'd like to add values of non-subscription content like a hard copy of a movie that would take the cost, length and how many times you have watched it to allow a comparison in usage of bought VS borrowed media*/

namespace Value_Checker
{
    class Program
    {
            static void Main()
            {
                ValueChecker();
            }
            static void ValueChecker()
            {
            Console.WriteLine(" Welcome to the Subscription Value Checker!\n\n First, the program will prompt you to enter how many subscriptions you would like to check.\n Then, the program will prompt you to input a name, cost and your total hours using your first subscription.\n Then it will move on to the second, third, etc. Good luck!\n");
            Console.WriteLine(" How many subscriptions would you like to check?");
            int k = Convert.ToInt32(Console.ReadLine());

            string[] subNames = new string[k];
            double[] subCosts = new double[k];
            double[] subTimes = new double[k];
            double[] subValue = new double[k];
            int counter = 1;
            int j = 0;

            Console.WriteLine(" What is the name of your first subscription?");
            subNames[0] = Console.ReadLine();
            Console.WriteLine(" How much did this subscription cost?");
            subCosts[0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" How much time did you use this subscription?");
            subTimes[0] = Convert.ToDouble(Console.ReadLine());
            
            while(counter < k)
            {
                Console.WriteLine(" What is the name of your next subscription?");
                subNames[counter] = Console.ReadLine();
                Console.WriteLine(" How much did this subscription cost?");
                subCosts[counter] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(" How much time did you use this subscription?");
                subTimes[counter] = Convert.ToDouble(Console.ReadLine());
                counter++;
            }


            Console.WriteLine("  Your Subscriptions:\n\n  Name                Value(Hours/Dollar Spent)\n-----------------------------------------------");
            while(j < counter)
            {
                subValue[j] = subTimes[j] / subCosts[j];
                string sp = "                                            ";
                int spaces = 25;
                Console.WriteLine("  " + subNames[j] + sp.Substring(0, (spaces - subNames[j].Length)) + subValue[j].ToString("N3"));
                j++;
            }



        }
        }
    }
