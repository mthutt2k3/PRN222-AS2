using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetAllProducts() => ProductDAO.GetAllProducts();

        public Product GetProductById(int id) => ProductDAO.GetProductById(id);

        public void AddProduct(Product product) => ProductDAO.AddProduct(product);

        public void UpdateProduct(Product product) => ProductDAO.UpdateProduct(product);

        public void DeleteProduct(int id) => ProductDAO.DeleteProduct(id);
    }
}
