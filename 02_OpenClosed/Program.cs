using System;

namespace _02_OpenClosed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SalaryCalculater salaryCalculater = new SalaryCalculater(new FullTimeEmployee());
            salaryCalculater.CalculateSalary();

        }
    }
    /*
    //Open Closed = nesneler değişime kapalı ancak genişletmeye açık olması gerekmektedir.
    public class FullTimeEmployee
    {
        public void CalculateSalary()
        {
            Console.WriteLine("Full");
        }
    }

    public class PartTimeEmployee
    {
        public void CalculateSalary()
        {
            Console.WriteLine("PartTime");
        }
    }

    public class SupportEmployee
    {
        public void CalculateSalary()
        {
            Console.WriteLine("Support");
        }
    }
    //iş yapan class'ı oluşturalım

    class SalaryCalculator
    {
        public void CalculateSalary(string employeeType)
        {
            if(employeeType == "Full")
            {
                new FullTimeEmployee().CalculateSalary();
            }
            else if (employeeType == "Support") //son eklendi yani değişiklik yapıldı.
            {
                new SupportEmployee().CalculateSalary();
            }
            else
            {
                new PartTimeEmployee().CalculateSalary();
            }
        }
    }
    */
    //normalde yukarıdaki gibi bir durumda eğer ben yeni bir destek personeli eklemek istediğim zaman iş classında da değişiklik yapmam gerek.
    //şimdi bu şekilde yapmak yerine interface ile yapmamız gerekecek ve Open Closed çiğnenmemiş olacak.
    public interface IEmployee
    {
        void CalculateSalary();
    }

    public class FullTimeEmployee : IEmployee
    {
        public void CalculateSalary()
        {
            Console.WriteLine("Full");
        }
    }

    public class PartTimeEmployee : IEmployee
    {
        public void CalculateSalary()
        {
            Console.WriteLine("Part");
        }
    }

    public class SupportEmployee : IEmployee
    {
        public void CalculateSalary()
        {
            Console.WriteLine("Support");
        }
    }

    //iş yapan classı yazalım.

    public class SalaryCalculater
    {
        private  readonly IEmployee employee;
        public SalaryCalculater(IEmployee employee)
        {
            this.employee = employee;
        }
        public void CalculateSalary()
        {
            this.employee.CalculateSalary();   
        }

    }
}
