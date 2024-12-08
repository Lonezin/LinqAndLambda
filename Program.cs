using LinqAndLambda.Entities;

namespace LinqAndLambda
{
    class Program
    {
        public static void Main(string[] args)
        {
            var category1 = new Category { Id = 1, Name = "Tools", Tier = 2 };
            var category2 = new Category { Id = 2, Name = "Computer", Tier = 1 };
            var category3 = new Category { Id = 3, Name = "Eletronics", Tier = 1 };
            
            var products = new List<Product>()
            {
                new Product(){ Id = 1, Name = "Computer", Price = 1100.0, Category = category2 },
                new Product(){ Id = 2, Name = "Hammer", Price = 90.0, Category = category1 },
                new Product(){ Id = 3, Name = "TV", Price = 1700.0, Category = category3 },
                new Product(){ Id = 4, Name = "Notebook", Price = 1300.0, Category = category2 },
                new Product(){ Id = 5, Name = "Saw", Price = 80.0, Category = category1 },
                new Product(){ Id = 6, Name = "Tablet", Price = 700.0, Category = category2 },
                new Product(){ Id = 7, Name = "Camera", Price = 700.0, Category = category3 },
                new Product(){ Id = 8, Name = "Printer", Price = 350.0, Category = category3 },
                new Product(){ Id = 9, Name = "MacBook", Price = 1800.0, Category = category2 },
                new Product(){ Id = 10, Name = "Sound Bar", Price = 700.0, Category = category3 },
                new Product(){ Id = 11, Name = "Level", Price = 70.0, Category = category1 }
            };
            
        }
    }
}

