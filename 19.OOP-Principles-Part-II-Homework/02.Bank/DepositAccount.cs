using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Bank
{
    public class DepositAccount : Account, IAcountMoneyDepositable, IAcountMoneyDrawable
    {
        public DepositAccount(Customer cust, decimal balance, decimal interestRate)
            : base(cust, balance, interestRate) { }
        public override decimal CalculateInterest(uint months)
        {
            if (months < 0)
            {
                throw new ArgumentException("Months cannot be negative number!");
            }
            if(this.Balance>0&& this.Balance<1000)
            {
                return 0m;
            }
            else
            {
                return months * this.InterestRate;
            }
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }
        public override string ToString()
        {
            return string.Format("Deposit Account");
        }
    }
}
