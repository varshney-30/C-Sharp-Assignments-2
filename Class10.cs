﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_ASSIGNMENTS_2
{
    class BankAccount1
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }

        public BankAccount1(int accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }
    }

    sealed class SavingsAccount : BankAccount
    {
        public double InterestRate { get; set; }

        public SavingsAccount(int accountNumber, double balance, double interestRate)
            : base(accountNumber, balance)
        {
            InterestRate = interestRate;
        }

        public void CalculateInterest(int numberOfMonths)
        {
            double monthlyInterestRate = InterestRate / 12;
            double interestEarned = Balance * monthlyInterestRate * numberOfMonths;
            Balance += interestEarned;

            Console.WriteLine($"Interest calculated for {numberOfMonths} months. New balance: ${Balance:F2}");
        }
    }

}
