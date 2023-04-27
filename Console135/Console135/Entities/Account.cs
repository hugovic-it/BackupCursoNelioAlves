using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console135.Entities
{
    public class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; } //dono da conta
        public double Balance { get; protected set; } //Saldo

        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount) { //Retirar
            Balance -= amount + 5.0;
        }
        public void Deposit(double amount) { 
            Balance += amount;
        }
    }
}
