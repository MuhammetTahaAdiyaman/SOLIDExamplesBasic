using System;

namespace _03_LiskovSubsitution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new PartTimeEmployee();
            Employee employee1 = new FullTimeEmployee();
        }
    }
    
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }

    class PartTimeEmployee : Employee
    {
        public decimal HourlyWage { get; set; }
    }

    class FullTimeEmployee : Employee
    {
        public decimal DailyWage { get; set; }
    }
}
