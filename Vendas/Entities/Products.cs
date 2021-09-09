using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.Entities
{
    class Products
    {
        List<Product> products = new List<Product>();

        public Products()
        {
            add();
        }

        public Products(int i)
        {
            
        }

        public void AddProduct(Product product, int quantidade)
        {


            if (products.Where(p => p.Name.ToUpper() == product.Name.ToUpper()).Any())
            {
                products.Where(p => p.Name.ToUpper() == product.Name.ToUpper()).FirstOrDefault().Quantidade += quantidade;
                products.Where(p => p.Name.ToUpper() == product.Name.ToUpper()).FirstOrDefault().TotalPrice = products.Where(p => p.Name.ToUpper() == product.Name.ToUpper()).FirstOrDefault().Price * products.Where(p => p.Name.ToUpper() == product.Name.ToUpper()).FirstOrDefault().Quantidade;
            }
            else
            {
                products.Add(product);
                products.Where(p => p.Name.ToUpper() == product.Name.ToUpper()).FirstOrDefault().Quantidade += quantidade;
                products.Where(p => p.Name.ToUpper() == product.Name.ToUpper()).FirstOrDefault().TotalPrice = products.Where(p => p.Name.ToUpper() == product.Name.ToUpper()).FirstOrDefault().Price * products.Where(p => p.Name.ToUpper() == product.Name.ToUpper()).FirstOrDefault().Quantidade;
            }

        }

        public Product GetByName(string name)
        {
            return products.Where(p => p.Name.ToUpper() == name.ToUpper()).FirstOrDefault();
        }

        public void add()
        {
            products.Add(new Product("Notebook", 1000.00));
            products.Add(new Product("Computador", 1200.00));
            products.Add(new Product("Mouse", 100.00));
            products.Add(new Product("Teclado", 120.00));
            products.Add(new Product("Monitor", 800.00));
            products.Add(new Product("Memória", 400.00));
            products.Add(new Product("Placa de Vídeo", 3000.00));
        }

        public double GetTotalPrice()
        {
            return products.Sum(p => p.Price * p.Quantidade);
        }
        public List<Product> Lista()
        {
            return products;
        }
    }
}
