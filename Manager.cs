using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePayrollSoftware
{
    internal class Manager : Staff
    {
        // fields
        private const float managerHourlyRate = 50;

        // properties
        public int Allowance { get; private set; }

        // constructor
        public Manager(string name) : base(name, managerHourlyRate) { }

        // methods

        public override void CalculatePay()
        {
            base.CalculatePay();

            Allowance = 1000;

            if (HoursWorked > 160) TotalPay += Allowance;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
