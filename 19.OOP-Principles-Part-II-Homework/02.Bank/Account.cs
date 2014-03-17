using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank
{
    public enum Customer { Individuals, Companies }
    public abstract class Account
    {
        private Customer cust;
        private decimal balance;
        private decimal interestRate;
        public Account(Customer cust, decimal balance, decimal interestRate)
        {
            this.Cust = cust;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }
        public Customer Cust
        {
            get { return this.cust; }
            set { this.cust = value; }
        }
        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public decimal InterestRate
        {
            get { return this.interestRate; }
            set { this.interestRate = value; }
        }
        public abstract decimal CalculateInterest(uint months);
    }
}
