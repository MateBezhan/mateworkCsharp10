using System;
using System.Collections.Generic;
using System.Text;

namespace mateworkCsharp10
{
    internal class Doctor : Employee
    {
        public string Specialization { get; set; }
        public int PatientsExamined { get; set; }

        public Doctor(string fullName, decimal salary, string specialization, int patientsExamined)
            : base(fullName, salary)
        {
            Specialization = specialization;
            PatientsExamined = patientsExamined;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Position: Doctor, Specialization: {Specialization}, Patients examined: {PatientsExamined}");
        }

        public override void PerformDuty()
        {
            Console.WriteLine($"Dr. {FullName} is examining a patient.");
            PatientsExamined++;
        }

        public override decimal CalculateBonus()
        {
            return PatientsExamined * 20;
        }
    }
}
