using System;

namespace _05_DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HomeIndex();
            CategoryIndex();
            Console.WriteLine("Hello World!");
        }

        static void HomeIndex()
        {
            //CategoryRepositoryDp categoryRepository = new CategoryRepositoryDp();
            //categoryRepository.GetCategories();
            Container container = new Container();
            container.GetInstance().GetCategories();
        }

        static void CategoryIndex()
        {
            //CategoryRepositoryDp categoryRepository = new CategoryRepositoryDp();
            //categoryRepository.GetCategories();
            Container container = new Container();
            container.GetInstance().GetCategories();
        }
    }
    /*
    //bu prensip bize bağımlılıkları tersine çevir der.
    //ilk önce nasıl bağımlı olunur bir bakalım. Daha sonra bağımlılıklardan nasıl kurtulabiliriz bir bakalım.
    class CategoryRepositoryEf
    {//EF kullanarak verileri çekmek istiyoruz
        public void GetCategories()
        {
            Console.WriteLine("ef");
        }
    }
    //yukarıda action metodlar oluşturduğumuzu varsayalım ve categorileri ef ile çektiğimizi varsayalım.
    //şimdi ben istiyorum ki dapper ile çekmek istiyorum
    class CategoryRepositoryDp
    {
        public void GetCategories()
        {
            Console.WriteLine("Dp");
        }
    }
    //homeindex ve category index içinde olan tüm insatance buna çevirmem gerekecek.
    */
    //bunun yerine şu şekilde bir geliştirme yapalım.
    
    
    public class Container
    {
        public ICategoryRepository GetInstance()
        {
            //return new CategoryRepositoryEf(); //artık tek bir yerden tüm süreci değişiklik yapabilirim.
            return new CategoryRepositoryDp();
        }
    }
    public interface ICategoryRepository
    {
        void GetCategories();
    }

    class CategoryRepositoryEf : ICategoryRepository
    {
        public void GetCategories()
        {
            Console.WriteLine("EF");
        }
    }

    class CategoryRepositoryDp : ICategoryRepository
    {
        public void GetCategories()
        {
            Console.WriteLine("DP");
        }
    }
}
