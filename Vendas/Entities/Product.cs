using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.Entities
{
    class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantidade { get; set; }

        public double TotalPrice { get; set; }

        public Product()
        {

        }
        public Product(string name, double price)
        {
            Id = Guid.NewGuid();
            Name = name;
            Price = price;
            Quantidade = 0;
            TotalPrice = 0; 
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Product))
                return false;
            Product other = obj as Product;
            return Name.Equals(other.Name);
        }


    }
}
