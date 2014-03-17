using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Bank
{
    public class MortgageAccount : Account, IAcountMoneyDepositable
    {
        public MortgageAccount(Customer cust, decimal balance, decimal interestRate)
            : base(cust, balance, interestRate) { }
        public override decimal CalculateInterest(uint months)
        {
            if (months < 0)
            {
                throw new ArgumentException("Months cannot be negative number!");
            }
            if (this.Cust == Customer.Companies)
            {
                if (months < 12)
                {
                    return months * (this.InterestRate / 2);
                }
                else
                {
                    return (12 * (this.InterestRate / 2)) + ((months - 12) * this.InterestRate);
                }
            }
            else
            {
                if (months <= 6)
                {
                    return 0M;
                }
                else
                {
                    return (months - 6) * this.InterestRate;
                }
            }
        }
        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }
        public override string ToString()
        {
            return string.Format("Mortgage Account");
        }
    }
}
