using Date.Entity.BaseEntity;
using System.Xml.Linq;

namespace Date.Entity.Entity
{
    public class Product : Entity<int>
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }


        public void UpdateProduct(string name, string description, decimal price)
        {
            Name = name;
            Description = description;
            Price = price;

        }

    }
}
