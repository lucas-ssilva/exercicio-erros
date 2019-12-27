using System;
using exceção.Entities;
using System.Globalization;
using System.Collections.Generic;
using exceção.Entities.Exceptions;

namespace exceção
{
    class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account a = new Account(number, holder, balance, limit);
                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            try { 
                a.Withdraw(valor);
                Console.WriteLine("New balance: " + a.Balance.ToString("F2"));
            }
            catch(DomainException e)
            {
                Console.WriteLine("Error! \n\r" + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Try again");
            }
        }
    }
}
