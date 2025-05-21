using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReloadOperationLecture
{
    internal class Salary
    {
        private decimal amount;
        public decimal Amount { get => amount; }

        public Salary(decimal amount)
        {
            this.amount = amount;
        }

        public static Salary operator +(Salary salary, decimal number)
        {
            return new Salary(salary.Amount + number);
        }
    }
}
