using System;

namespace BankInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal defaultBalance = 100;
            int choice = 0;
            decimal money = 0;

            Console.WriteLine("Hello Welcome To Banking!");
            Console.WriteLine($"Your current account balance is : {defaultBalance} Rs.");

            while (true)
            {
                Console.WriteLine("\nPress 1 --> Credit by UPI \nPress 2 --> Credit by NetBanking\nPress 3 --> Debit by ATM\nPress 4 --> Debit by Cash \nPress 5 --> Exit ");

                try
                {
                    choice = int.Parse(Console.ReadLine());
                    
                    if (choice == 5)
                    {
                        break;
                    }
                    if (choice < 0 || choice > 5)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    
                        Console.WriteLine("Enter Amount to Credit/Debit :");
                        money = decimal.Parse(Console.ReadLine());
                    
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Invalid choice... Please select correct option.");
                }
                finally
                {
                    Console.WriteLine("***** Thank you for Banking with us *****");
                }


                switch (choice)
                {
                    case 1:
                        CreditThroughUPI upi = new CreditThroughUPI(defaultBalance);
                        defaultBalance = upi.CreditMoney(money);
                        Console.WriteLine($"Account Current balance : {defaultBalance}");
                        break;

                    case 2:
                        CreditThroughNetBanking netbank = new CreditThroughNetBanking(defaultBalance);
                        defaultBalance = netbank.CreditMoney(money);
                        Console.WriteLine($"Account Current balance : {defaultBalance}");
                        break;

                    case 3:
                        DebitThroughATM atm = new DebitThroughATM(defaultBalance);
                        defaultBalance = atm.DebitMoney(money);
                        Console.WriteLine($"Account Current balance : {defaultBalance}");
                        break;

                    case 4:
                        DebitThroughATM cash = new DebitThroughATM(defaultBalance);
                        defaultBalance = cash.DebitMoney(money);
                        Console.WriteLine($"Account Current balance : {defaultBalance}");
                        break;
                }


            }
            

        }
    }
}
