using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank1
{
    class Program
    {

        static int pin;
        static int balance = 4500;

        static void Main(string[] args)
        {
            Console.WriteLine("ENTER YOUR PIN NUMBER");
            pin = int.Parse(Console.ReadLine());

            Console.WriteLine("CHECK BALANCE PRESS 1");
            Console.WriteLine("WITHDRAW AMOUNT PRESS 2");
            Console.WriteLine("DEPOSITE AMOUNT PRESS 3");
            int a = int.Parse(Console.ReadLine());

            if (a == 1)
            {
                Balance();
            }
            else if (a == 2)
            {
                withdraw();
            }
            else if (a == 3)
            {
              deposit();
            }
        }

        static void Balance()
        {
            Console.WriteLine("ENTER YOUR PIN AGAIN TO CHECK YOUR BALANCE:");
            int enteredPin = Convert.ToInt32(Console.ReadLine());

            if (enteredPin == pin)
            {
                Console.WriteLine("YOUR BALANCE IS: " + balance);
            }
            else
            {
                Console.WriteLine("INCORRECT PIN");
            }
            Console.ReadLine();
        }

        static void withdraw()
        {
            Console.WriteLine("ENTER THE AMOUNT TO WITHDRAW:");
            int amount = int.Parse(Console.ReadLine());

            Console.WriteLine("ENTER YOUR PIN AGAIN:");
            int enteredPin = int.Parse(Console.ReadLine());

            if (enteredPin == pin)
            {
                if (amount <= balance)
                {
                    balance = balance-amount;
                    Console.WriteLine("WITHDRAW SUCCESSFUL");
                    Console.WriteLine("YOUR REMAINING BALANCE IS: " + balance);
                }
                else
                {
                    Console.WriteLine("INSUFFICIENT BALANCE");
                }
            }
            else
            {
                Console.WriteLine("INCORRECT PIN");
            }

            Console.ReadLine();
        }
        static void deposit()
        {
            Console.WriteLine("ENTER THE AMOUNT TO DEPOSIT:");
            int amount = int.Parse(Console.ReadLine());

            Console.WriteLine("ENTER YOUR PIN AGAIN:");
            int enteredPin = int.Parse(Console.ReadLine());

            if (enteredPin == pin)
            {
                balance = balance + amount;
                Console.WriteLine("DEPOSIT SUCCESSFUL");
                Console.WriteLine("YOUR NEW BALANCE IS: " + balance);
            }
            else
            {
                Console.WriteLine("INCORRECT PIN");
            }  

            Console.ReadLine();
        }
    }
}