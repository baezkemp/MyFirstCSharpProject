using System;

namespace SimplePayrollSoftware
{
    internal class Staff
    {
        // fields
        private float hourlyRate;
        private int hWorked;

        // properties
        public float TotalPay { get; protected set; }
        public float BasicPay { get; private set; }
        public string NameOfStaff { get; private set; }
        public int HoursWorked
        {
            get { return hWorked; }
            set
            {
                if (value > 0)
                    hWorked = value;
                else
                    hWorked = 0;
            }
        }

        // contstructor
        public Staff(string name, float rate)
        {
            NameOfStaff = name;
            hourlyRate = rate;
        }

        // methods

        public virtual void CalculatePay()
        {
            Console.WriteLine("Calculating pay...");
            BasicPay = hWorked * hourlyRate;
            TotalPay = BasicPay;
        }

        public override string ToString()
        {
            return "\nName of Staff: " + NameOfStaff + "\nHourly Rate: " + hourlyRate + "\nHours Worked: " + hWorked + "\nBasic Pay: " + BasicPay + "\n\nTotal Pay: " + TotalPay;
        }
    }
}