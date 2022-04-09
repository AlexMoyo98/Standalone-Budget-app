using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//alex_moyo_18010184_not_yet_migrated
namespace Standalone
{
    class Program
    {    
        static void Main(string[] args)
        {

            //calls the Run() method from the Program class
            Run();   
        }

        public static void Run()
        {
            try {
                // Console.WriteLine("Please enter a number ");
                // int number = Convert.ToInt32(Console.ReadLine());
                // Console.WriteLine("Your number is = " + number);
                // Console.ReadLine();

                //Create a Alex object
                Declarations Alex = new Declarations();

                //stores expenses into an array
                Alex.Store[0] = Alex.Tax;
                Alex.Store[1] = Alex.Groceries;
                Alex.Store[2] = Alex.Water;
                Alex.Store[3] = Alex.Travelling;
                Alex.Store[4] = Alex.Cell_phone;
                Alex.Store[5] = Alex.Other;
                Alex.Store[6] = Alex.Rental;
                Alex.Store[7] = Alex.Months; // calculations about loan 

                Console.WriteLine("\n__Welcome to Standalone application__\n");
                //informtion that will capture user input and output later
                Console.WriteLine("Enter your monthly income (Before deductions) ");
                //calls the variable from declaration class
                Alex.Income = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter your monthly Tax deducted");
                Alex.Store[0] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How much do you spend on Groceries");
                Alex.Store[1] = Convert.ToDouble (Console.ReadLine());

                Console.WriteLine("How much do you spend on Water & Lights");
                Alex.Store[2] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("How much do you spend on travelling (including petrol)");
                Alex.Store[3] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("How much do you spend on Smartphone || Data || Telephone");
                Alex.Store[4] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("How much do you spend on other expenses");
                Alex.Store[5] = Convert.ToDouble(Console.ReadLine());

                //the following condition will capture the renting and buying property
                bool Continue = false;
                //gets input
                Console.WriteLine("\nHere you have two options \nChoose (1) for Renting accomodation " +
                        "or (2) for Buying a property");
                int Choice = int.Parse(Console.ReadLine());



                // the application will keep on looping until the user inputs the correct input
                while (!Continue)
                {
                    //if user input 1 the system will output the condition under option chosen by the user
                    if (Choice == 1)
                    {
                        Console.WriteLine("How much do you spend on Renting Accomodation a month");
                        Alex.Store[6] = Convert.ToDouble(Console.ReadLine());
                        Alex.Ta = Alex.Income / 100 * Alex.Store[0]; //calculations
                        Alex.Cal = Alex.Income - Alex.Ta; //calculations that subract tax from income entered by user
                        Alex.Groce = Alex.Cal - Alex.Store[1];
                        Alex.Light = Alex.Groce - Alex.Store[2];
                        Alex.Travel = Alex.Light - Alex.Store[3];
                        Alex.Cell = Alex.Travel - Alex.Store[4];
                        Alex.Other_ex = Alex.Cell - Alex.Store[5];
                        Alex.Rent = Alex.Other_ex - Alex.Store[6];

                        // Displays the user inputs 
                        Console.WriteLine("\nYour monthly income is R " + Alex.Income +
                            "\nAfter Tax deductions this is the remainder of your salary R " + Alex.Cal +
                            "\nAfter Purchasing Groceries this is the remainder of your salary R " + Alex.Groce +
                            "\nAfter paying for Water & Lights this is the remainder of your salary R " + Alex.Light +
                            "\nAfter your Travelling budget this is the remainder of your salary R " + Alex.Travel +
                            "\nAfter your Cell phone/telephone expenses this is the remainder of your salary R " + Alex.Cell +
                            "\nAfter Other expenses this is the remaineder of your salary R " + Alex.Other_ex +
                            "\nAfter your Rental Amount this is the remainder of your salary R " + Alex.Rent);

                        //prompt the user to press enter to continue
                        Console.WriteLine("\nPress enter to continue");
                        Console.ReadLine();
                        break;
                    }
                    // if user decides to choose option it will output the following
                    else if (Choice == 2)

                    {
                        //prompts the user to enter all the details about the property purchase
                        Console.WriteLine("How much is the purchase price for the property");
                        Alex.Purchase_prop = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("What is the Total deposit for the Property");
                        Alex.Total_dep = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("What is the interest rate for the property i.e (2,3)");
                        Alex.Interest_rate = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Number of months it will take to repay the home loan (between 240 and 340 Months)");
                        Alex.Months_repay = Convert.ToDouble(Console.ReadLine());


                        //interest rate calculations
                        Alex.Ta = Alex.Income / 100 * Alex.Store[0]; //calculations
                        Alex.Cal = Alex.Income - Alex.Ta; //calculations that subract tax from income entered by user

                        //the expenses stored in the arrays will be calculated
                        Alex.Groce = Alex.Cal - Alex.Store[1];
                        Alex.Light = Alex.Groce - Alex.Store[2];
                        Alex.Travel = Alex.Light - Alex.Store[3];
                        Alex.Cell = Alex.Travel - Alex.Store[4];
                        Alex.Other_ex = Alex.Cell - Alex.Store[5];
                        

                        //the following calculates the home loan
                        Alex.Price = Alex.Purchase_prop - Alex.Total_dep;

                        //purchase price * interest rate * years/months
                        Alex.Rate = Alex.Interest_rate / 100;
                        Alex.Loan = Alex.Price * Alex.Rate * 20;

                        Alex.Months = Alex.Loan / Alex.Months_repay;

                        Alex.Repay = Alex.Other_ex - Alex.Months;
                        //calculates the third of income of the user
                        double Third = Alex.Income / 100 * 33.333333;

                        // captured data output
                        Console.WriteLine("\nYour monthly income is R " + Alex.Income +
                            "\nAfter Tax deductions this is the remainder of your salary R " + Alex.Cal +
                            "\nAfter Purchasing Groceries this is the remainder of your salary R " + Alex.Groce +
                            "\nAfter paying for Water & Lights this is the remainder of your salary R " + Alex.Light +
                            "\nAfter your Travelling budget this is the remainder of your salary R " + Alex.Travel +
                            "\nAfter your Cell phone/telephone expenses this is the remainder of your salary R " + Alex.Cell +
                            "\nAfter Other expenses this is the remaineder of your salary R " + Alex.Other_ex +
                            "\nProperty price is R " + Alex.Purchase_prop +
                            "\nDeposit of the property is R " + Alex.Total_dep + "" +
                            "\nYou will repay your home loan for a period of " + Alex.Months_repay + " \nThe monthly amount will be R " + Alex.Months +
                            "\nIf you would pay the monthly amount stated, the remainder of your salary after month repayments will be R " + Alex.Repay);
                        //if the monthly home loan repayment is more than a third of the users gross monthly salary the 
                        // software will allert the user that approval of the home is likely or not.
                        if (Alex.Months > Third)
                        {
                            Console.WriteLine("\n\aApproval of the loan is unlikely because the Home Loan repayment is more than your third income salary");
                        }
                        else
                        {
                            Console.WriteLine("\nYour loan will be approved, you do qualify for the loan");
                        }
                        //prompts the user to press enter to continue
                        Console.WriteLine("Please press enter to continue");
                        Console.ReadLine();
                        break;

                    }
                    //if the user input is invalid the system will notify the user 
                    else
                    {
                        Console.WriteLine("\nInvalid number \a" +
                            "\nPlease enter either 1 or 2");
                        Choice = int.Parse(Console.ReadLine());
                    }

                }
                //the following will ask the user if he or she would like to retry or exit the program
                bool Retry = false;
                Console.WriteLine("\nIf you would like to retry the application enter 1" +
                    "\nEnter any number from 2 - 9 to terminate the application");
                int Cap = int.Parse(Console.ReadLine());

                while (!Retry)
                { //the following code will restart the application 
                    if (Cap == 1)
                    {
                        //method to restart the application
                        Run();
                    }
                    else
                    {
                        //if the user selects any other key the application will terminate
                        Console.WriteLine("Thank you for using Standalone application" +
                            "\nPress Enter to exit");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
            } 
            catch (Exception me)
            {
                Console.WriteLine(me.Message);
            }
        }
    }
}
