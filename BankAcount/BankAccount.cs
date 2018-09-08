using System;
using System.Collections.Generic;
using System.Text;

namespace BankAcount
{
    class BankAccount
    {
        private int id;
        private double balance;

        public BankAccount(): this(0,0)
        {
        }
        public BankAccount(int id) : this(id, 0.0)
        {
        }
        public BankAccount(double balance) : this(0, balance)
        {
        }
        public BankAccount(int id, double balance)
        {
            this.id = id;
            this.balance = balance;
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public void Deposit(double amount)
        {
            this.balance += amount;
        }
        public void Withdraw(double amount)
        {
            this.balance -= amount;
        }

        public override string ToString()
        {
            return $"Account ID{this.id}, balance {this.balance:f2}";
        }

    }
}
