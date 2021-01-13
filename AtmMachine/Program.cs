using System;

namespace AtmMachine
{
    public class Program
    {
        static public decimal balance;
        static public void Main(string[] args)
        {
            userInterface();
        }

        static public void userInterface()
        {
            bool exitProgram = false;
            while (exitProgram == false)
            {
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine();
                
                Console.WriteLine("Welcome to Dewey, Cheatem, and Howe Banking Alliance");
                Console.WriteLine();
                Console.WriteLine("Available Options");
                Console.WriteLine();
                Console.WriteLine("1. View Balance");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Exit");
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine();
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        decimal currentBalance = balance;
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------------");
                        Console.WriteLine($"Your Current Balance is: {ViewBalance()}");
                        Console.WriteLine("-----------------------------------------------------");
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------------");
                        Console.WriteLine("How much money would you like to take from our bank?");
                        string userAmount = Console.ReadLine();
                        decimal withdraw = StringToDecimal(userAmount);
                        Withdraw(withdraw);                        
                        Console.WriteLine($"Updated Balance: {balance}");
                        Console.WriteLine("-----------------------------------------------------");
                        Console.WriteLine();
                        break;
                    case "3":
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------------");
                        Console.WriteLine("How much would you like to deposit?");
                        string userDeposit = Console.ReadLine();
                        decimal deposit = StringToDecimal(userDeposit);
                        Console.WriteLine($"Deposit Complete.");                        
                        Deposit(deposit);
                        Console.WriteLine($"Updated Balance: {balance}");
                        Console.WriteLine("-----------------------------------------------------");
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------------");
                        Console.WriteLine("Thank you for.. trusting us with your money, we will spend it wisely");
                        Console.WriteLine("Program Terminated");
                        Console.WriteLine("-----------------------------------------------------");
                        Console.WriteLine();
                        exitProgram = true;
                        break;

                    default:
                        Console.WriteLine("Invalid Selection Made");
                        break;
                }
            
            
            }
        }
        static public decimal StringToDecimal(string str)
        {
            decimal number = 0;
            try
            {

                number = Convert.ToDecimal(str);


            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Input.");
                Console.WriteLine(e.Message);

            }
            return number;
        }

        static public decimal ViewBalance()
        {
            return balance;
        }
        static public decimal Withdraw(decimal amountToWithdraw)
        {
            decimal newTotal = balance - amountToWithdraw;
            if (newTotal < 0) { Console.WriteLine("Unable to Complete Action.  Account would be overdrawn"); }
            else { balance = newTotal; }
            return balance;
        }
        static public decimal Deposit(decimal amountDeposit)
        {
            balance += amountDeposit;
            return balance;
        }

        }
}
