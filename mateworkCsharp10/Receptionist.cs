using System;
using System.Collections.Generic;
using System.Text;

namespace mateworkCsharp10
{
    internal class Receptionist : Employee
    {
        public int RegisteredPatients { get; set; }

        public Receptionist(string fullName, decimal salary, int registeredPatients)
            : base(fullName, salary)
        {
            RegisteredPatients = registeredPatients;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Position: Receptionist, Registered patients: {RegisteredPatients}");
        }

        public override void PerformDuty()
        {
            Console.WriteLine($"Receptionist {FullName} is registering a patient.");
            RegisteredPatients++;
        }

        public override decimal CalculateBonus()
        {
            return RegisteredPatients * 5;
        }
    }
}
