/*
 * Budget
 * ITSE 1430
 * Semester 2020
 * Ayush Bhattarai
 */

using System;

namespace Budget
{
    class Program
    {
        static string accountName = "";
        static string accountNumber;
        static decimal startingBalance;

        //Deposit
        static string amountInStringOut;
        static decimal amountOut = 0;

        static string descriptionOut;

        static string catagoryOut;
        static string checkNumberOut;
        static string dateOut;

        //WithDraw
        static string amountInString;
        static decimal amount = 0;

        static string description;

        static string catagory;
        static string checkNumber;
        static string date;

        static void Main(string[] args)
        {
            bool firstTime = true;
            bool accountNameEntered = false;

            bool wrongNumberEntered = true;

            string startingBalanceString;

            Console.WriteLine("Budget\nITSE 1430\nSpring 2021\nAyush Bhattarai\n");

            while(String.IsNullOrEmpty(accountName) && accountNameEntered == false)
            {
                if(firstTime == false)
                {
                    Console.WriteLine("Value is required");
                }
                else
                {
                    Console.WriteLine("\nAccount Name?");
                }

                accountName = Console.ReadLine();
                firstTime = false;
            }

            if(!String.IsNullOrEmpty(accountName))
            {
                accountNameEntered = true;
            }

            if(accountNameEntered == true)
            {
                while (wrongNumberEntered)
                {
                    Console.WriteLine("\nAccount Number? (Digits only, must be 12 characters long, and may not start or end with a 0.");
                    accountNumber = Console.ReadLine();

                    if (IsDigitsOnly(accountNumber) && accountNumber.Length == 12 && accountNumber[0] != '0' && accountNumber[11] != '0')
                    {
                        wrongNumberEntered = false;
                    }
                }
            }

            if(accountNameEntered == true && wrongNumberEntered == false)
            {
                bool rightBalanceEntered = false; 

                while(!rightBalanceEntered)
                {
                    Console.WriteLine("\nStarting Account Balance?");
                    startingBalanceString = Console.ReadLine();
                    decimal.TryParse(startingBalanceString, out startingBalance);
                    
                    if(startingBalance == 0)
                    {
                        rightBalanceEntered = false;
                        Console.WriteLine("Please Enter Numbers only.");
                    }
                    else
                    {
                        rightBalanceEntered = true;
                        ShowMenu();
                    }
                }
            }
        }

        static bool IsDigitsOnly(string _string)
        {
            foreach (char c in _string)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private static void Deposit()
        {
            Console.Clear();
            Console.WriteLine("Budget\nITSE 1430\nSpring 2021\nAyush Algburi\n");

            Console.WriteLine("Account Name: " + accountName);
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Account Balance: " + "$" + startingBalance + "\n");

            while(amount <= 0)
            {
                Console.WriteLine("\nAmount? (Can only be positive) (Required) ");
                amountInString = Console.ReadLine();
                decimal.TryParse(amountInString, out amount);
            }

            Console.WriteLine("\nDescription? (Required)");
            description = Console.ReadLine();

            Console.WriteLine("\nWould you like to add a Category (Optional)");
            Console.WriteLine("1) Yes");
            Console.WriteLine("2) No");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("\nCatagory?");
                    catagory = Console.ReadLine();
                    CheckNumber();
                    break;
                case "2":
                    CheckNumber();
                    break;
                default:
                    CheckNumber();
                 break;
            }
        }

        private static void CheckNumber()
        {
            Console.WriteLine("\nWould you like to add a Check Number?");
            Console.WriteLine("1) Yes");
            Console.WriteLine("2) No");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("\nCheck Number?");
                    checkNumber = Console.ReadLine();
                    Date();
                    break;
                case "2":
                    Date();
                    break;

                default:
                    Date();
                    break;
            }
        }

        private static void Date()
        {
            Console.WriteLine("\nWould you like to add a Date?");
            Console.WriteLine("1) Yes");
            Console.WriteLine("2) No");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("\nDate? (MM/dd/yyyy)");
                    date = Console.ReadLine();

                    Console.WriteLine("\nDeposited!");
                    startingBalance += amount;
                    System.Threading.Thread.Sleep(2000);
                    ShowMenu();
                    break;

                case "2":
                    Console.WriteLine("\nDeposited!");
                    startingBalance += amount;
                    System.Threading.Thread.Sleep(2000);
                    ShowMenu();
                    break;

                default:
                    Console.WriteLine("\nDeposited!");
                    startingBalance += amount;
                    System.Threading.Thread.Sleep(2000);
                    ShowMenu();
                    break;
            }
        }

        private static void WithDraw()
        {
            Console.Clear();
            Console.WriteLine("Budget\nITSE 1430\nSpring 2021\nAyush Algburi\n");

            Console.WriteLine("Account Name: " + accountName);
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Account Balance: " + "$" + startingBalance + "\n");

            while (amountOut <= 0 || amountOut > startingBalance)
            {
                Console.WriteLine("\nAmount? (Can only be positive) (Required) ");
                amountInStringOut = Console.ReadLine();
                decimal.TryParse(amountInStringOut, out amountOut);
                if(amountOut > startingBalance)
                {
                    Console.WriteLine("Not Enough Money!");
                }
            }

            Console.WriteLine("\nDescription? (Required)");
            descriptionOut = Console.ReadLine();

            Console.WriteLine("\nWould you like to add a Category (Optional)");
            Console.WriteLine("1) Yes");
            Console.WriteLine("2) No");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("\nCatagory?");
                    catagoryOut = Console.ReadLine();
                    CheckNumberOut();
                    break;
                case "2":
                    CheckNumberOut();
                    break;
                default:
                    CheckNumberOut();
                    break;
            }
        }

        private static void CheckNumberOut()
        {
            Console.WriteLine("\nWould you like to add a Check Number?");
            Console.WriteLine("1) Yes");
            Console.WriteLine("2) No");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("\nCheck Number?");
                    checkNumberOut = Console.ReadLine();
                    DateOut();
                    break;
                case "2":
                    DateOut();
                    break;

                default:
                    DateOut();
                    break;
            }
        }

        private static void DateOut()
        {
            Console.WriteLine("\nWould you like to add a Date?");
            Console.WriteLine("1) Yes");
            Console.WriteLine("2) No");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("\nDate? (MM/dd/yyyy)");
                    dateOut = Console.ReadLine();

                    Console.WriteLine("\nWithdrawn!");
                    startingBalance -= amountOut;
                    System.Threading.Thread.Sleep(2000);
                    ShowMenu();
                    break;

                case "2":
                    Console.WriteLine("\nWithdrawn!");
                    startingBalance -= amountOut;
                    System.Threading.Thread.Sleep(2000);
                    ShowMenu();
                    break;

                default:
                    Console.WriteLine("\nWithdrawn!");
                    startingBalance -= amountOut;
                    System.Threading.Thread.Sleep(2000);
                    ShowMenu();
                    break;
            }
        }

        private static void Quit()
        {
            QuitMenu();
        }

        private static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Budget\nITSE 1430\nSpring 2021\nAyush Algburi\n");

            Console.WriteLine("Account Name: " + accountName);
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Account Balance: " + "$" + startingBalance + "\n");

            Console.WriteLine("Choose from the options:");
            Console.WriteLine("1) Deposit");
            Console.WriteLine("2) Withdraw");
            Console.WriteLine("3) Quit");

            switch (Console.ReadLine())
            {
                case "1":
                    Deposit();
                    break;
                case "2":
                    WithDraw();
                    break;
                case "3":
                    Quit();
                    break;
                default:
                    Console.WriteLine("Wrong Input.");
                    System.Threading.Thread.Sleep(0400);
                    ShowMenu();
                    break;
            }
        }

        private static void QuitMenu()
        {
            Console.Clear();
            Console.WriteLine("Budget\nITSE 1430\nSpring 2021\nAyush Algburi\n");

            Console.WriteLine("Account Name: " + accountName);
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Account Balance: " + "$" + startingBalance + "\n");

            Console.WriteLine("Are you sure?");
            Console.WriteLine("1) Yes");
            Console.WriteLine("2) No");

            switch (Console.ReadLine())
            {
                case "1":
                    Environment.Exit(0);
                    break;
                case "2":
                    ShowMenu();
                    break;
                default:
                    ShowMenu();
                    break;
            }
        }
    }
}
