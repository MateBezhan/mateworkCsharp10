using System;
using System.Collections.Generic;
using System.Text;

namespace mateworkCsharp10
{
    internal class Nurse : Employee
    {
        public string Department { get; set; }
        public int ShiftsCompleted { get; set; }

        public Nurse(string fullName, decimal salary, string department, int shiftsCompleted)
            : base(fullName, salary)
        {
            Department = department;
            ShiftsCompleted = shiftsCompleted;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Position: Nurse, Department: {Department}, Shifts completed: {ShiftsCompleted}");
        }

        public override void PerformDuty()
        {
            Console.WriteLine($"Nurse {FullName} is assisting a patient.");
        }

        public override decimal CalculateBonus()
        {
            return ShiftsCompleted * 15;
        }
    }
}
