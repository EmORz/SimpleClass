using System;
using System.Collections.Generic;

namespace BankAcount
{
    class Program
    {
        static void Main(string[] args)
        {
            var accounts = new Dictionary<int, BankAccount>();
            var command = Console.ReadLine();


            while (command != "End")
            {
                var input = command.Split();
                
                //
                switch (input[0])
                {
                    case "Create": Create(int.Parse(input[1]), accounts);
                        break;
                    case "Deposit":
                        Deposit(int.Parse(input[1]), double.Parse(input[2]), accounts);
                        break;
                    case "Withdraw":
                        Withdraw(int.Parse(input[1]), double.Parse(input[2]), accounts);
                        break;
                    case "Print":
                        Print(int.Parse(input[1]), accounts);
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }
        }

        private static void Print(int id, Dictionary<int, BankAccount> accounts)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
                return;
            }
            Console.WriteLine(accounts[id].ToString());
        }

        private static void Withdraw(int id, double amount, Dictionary<int, BankAccount> accounts)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
                return;
            }
            if (accounts[id].Balance<amount)
            {
                Console.WriteLine("Insufficient balance");
                return;
            }
            accounts[id].Withdraw(amount);
        }

        private static void Deposit(int id, double amount, Dictionary<int, BankAccount> accounts)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
                return;
            }
            accounts[id].Deposit(amount);
        }

        private static void Create(int id, Dictionary<int, BankAccount> accounts)
        {
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
                return;
            }
            accounts[id] = new BankAccount(id);
        }
    }
}
