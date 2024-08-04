using System;

namespace _01_SingleResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    //Single Responsibility = bir class veya metodun sorumluluğunun tek olmasıdır.
    //burada bir class içinde bir parametre bir validasyon ve bir de method var bu şekilde Single Responsibility'e aykırı bir durum.
    //class Customer
    //{
    //    public string Name { get; set; }

    //    public bool ValidateName(string name)
    //    {
    //        return !string.IsNullOrWhiteSpace(name);
    //    }

    //    public void SayHello(string name)
    //    {
    //        Console.WriteLine("Hello" + name);
    //    } 
    //}

    class Customer
    {
        public string Name { get; set; }             
    }

    class CustomerValidate
    {
        public bool ValidateName(string name)
        {
            return !string.IsNullOrWhiteSpace(name);
        }
    }

    class CustomerManager
    {
        public void SayHello(string name)
        {
            Console.WriteLine("Hello"+name);
        }
    }
}
