using System;

namespace _04_InterfaceSegregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    /*
    //alakalı interfaceleri parçalamalısın. Yani bir interface içinde alakasız bir şey olmamalı 
    public interface IRepository
    {
        void GetCategories();
        void GetProducts();

    }

    public class CategoryRepository : IRepository
    {
        public void GetCategories()
        {
            Console.WriteLine("List Categories");
        }
        //mecburen bu da geldi ama burada bu method ile işim yok
        public void GetProducts()
        {
            throw new NotImplementedException();
        }
    }

    public class ProductRepository : IRepository
    {
        //burada da bu method ile işim yok
        public void GetCategories()
        {
            throw new NotImplementedException();
        }

        public void GetProducts()
        {
            Console.WriteLine("List Products");
        }
    }
    */
    //işte yukarıdaki sebeplerden dolayı interface parçalamamız gerekmektedir.
    public interface ICategoryRepository
    {
        void GetCategory();
    }
    public interface IProductRepository
    {
        void GetProduct();
    }

    public class CategoryRepository : ICategoryRepository
    {
        public void GetCategory()
        {
            Console.WriteLine("List Categories");
        }
    }

    public class ProductRepository : IProductRepository
    {
        public void GetProduct()
        {
            Console.WriteLine("List Products");
        }
    }
}
