using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank
{
    class LoanAccount : Account, IAcountMoneyDepositable
    {
        public LoanAccount(Customer cust, decimal balance, decimal interestRate)
            : base(cust, balance, interestRate) { }
        public override decimal CalculateInterest(uint months)
        {
            if (months < 0)
            {
                throw new ArgumentException("Months cannot be negative number!");
            }
            if (this.Cust == Customer.Individuals)
            {
                months -= 3;
            }
            else if (this.Cust == Customer.Companies)
            {
                months -= 2;
            }
            if (months < 0)
            {
                return 0M;
            }
            return months * this.InterestRate;
        }

        public void Deposit(decimal amount)
        {
            base.Balance += amount;
        }
        public override string ToString()
        {
            return string.Format("Loan Account");
        }
    }
}
