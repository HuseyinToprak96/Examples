using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Patterns
{
    /*
     3. Builder: Karmaşık nesnelerin adım adım oluşturulmasını sağlayan bir desendir. Nesnenin yapısı adımlara ayrılır ve adımların ardışık olarak tamamlanmasıyla nesne oluşturulur.
     */
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }

    public class ProductBuilder
    {
        private Product product;

        public ProductBuilder()
        {
            product = new Product();
        }

        public ProductBuilder SetName(string name)
        {
            product.Name = name;
            return this;
        }

        public ProductBuilder SetDescription(string description)
        {
            product.Description = description;
            return this;
        }

        public ProductBuilder SetPrice(double price)
        {
            product.Price = price;
            return this;
        }

        public Product Build()
        {
            return product;
        }
    }

}
