using System.Globalization;

namespace LinqAndLambda.Entities
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public Product()
        {
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price.ToString("F2", CultureInfo.InvariantCulture)}, Tier: {Category.Tier}";
        }
    }
}

