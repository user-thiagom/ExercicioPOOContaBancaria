using ExercicioPOOContaBancaria.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOOContaBancaria.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            WithdrawLimit = withdrawLimit;
            Deposit(balance);
        }

        public override string ToString()
        {
            return $"{Number} - {Holder}, $ {Balance}" +
                   $"\nWithdraw Limit: {WithdrawLimit}";
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance <= 0)
                throw new DomainException("Error! Not Enough Balance!");

            if (amount > WithdrawLimit)
                throw new DomainException("The amount exceeds withdraw limit");
            
            Balance -= amount;
        }
    }
}
