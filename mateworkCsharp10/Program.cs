namespace mateworkCsharp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
        {
            new Doctor("John Smith", 3000, "Cardiology", 10),
            new Nurse("Anna Brown", 1500, "Surgery", 20),
            new Receptionist("Mary Jones", 1000, 30)
        };

            foreach (Employee emp in employees)
            {
                emp.ShowInfo();
                emp.PerformDuty();
                Console.WriteLine($"Bonus: {emp.CalculateBonus()}");
                Console.WriteLine("-----------------------");
            }

            // Test salary protection
            try
            {
                employees[0].Salary = -100;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            employees[0].RaiseSalary(500);
            Console.WriteLine($"New salary: {employees[0].Salary}");
        }
    }
}
