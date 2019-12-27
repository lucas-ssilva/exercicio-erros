using System;
using System.Collections.Generic;
using System.Text;
using exceção.Entities.Exceptions;

namespace exceção.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double valor)
        {
            Balance += valor;
        }

        public void Withdraw(double valor)
        {
            if (WithdrawLimit < valor)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if (valor > Balance)
            {
                throw new DomainException("Not enough balance");
            }
            Balance -= valor;
        }
    }
}
