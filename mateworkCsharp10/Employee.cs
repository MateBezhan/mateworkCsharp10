using System;
using System.Collections.Generic;
using System.Text;

namespace mateworkCsharp10
{
    internal class Employee
    {
        private decimal _salary;

        public string FullName { get; set; }

        public decimal Salary
        {
            get { return _salary; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Salary cannot be negative.");
                _salary = value;
            }
        }

        public Employee(string fullName, decimal salary)
        {
            FullName = fullName;
            Salary = salary;
        }

        public void RaiseSalary(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Raise amount must be positive.");
                return;
            }
            Salary += amount;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {FullName}, Salary: {Salary}");
        }

        public abstract void PerformDuty();

        public abstract decimal CalculateBonus();
    }
}
