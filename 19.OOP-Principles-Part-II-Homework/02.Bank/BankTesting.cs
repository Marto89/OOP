/*
 A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. Customers could be individuals or companies.
	All accounts have customer, balance and interest rate (monthly based). Deposit accounts are allowed to deposit and with draw money. Loan and mortgage accounts can only deposit money.
All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.
Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
Deposit accounts have no interest if their balance is positive and less than 1000.
Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
Your task is to write a program to model the bank system by classes and interfaces. You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.
 */
using System;

namespace _02.Bank
{
    class BankTesting
    {
        static void Main(string[] args)
        {
            Account[] accounts =
			{
				new DepositAccount(Customer.Individuals,3000,0.5M),
				new LoanAccount(Customer.Individuals,20000,0.9M),
				new LoanAccount(Customer.Companies,20000,0.9M),
				new MortgageAccount(Customer.Companies,50000,1M),
				new MortgageAccount(Customer.Individuals,50000,1M)
			};
            foreach (var n in accounts)
            {
                Console.WriteLine("Interest of {0} with balance {2} and interest rate {3}%(monthly based) for 24 months is: {1:F2}%.", n.ToString(), n.CalculateInterest(24), n.Balance, n.InterestRate);
            }
        }
    }
}
