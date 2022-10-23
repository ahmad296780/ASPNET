using System.Collections.Generic;
using Testing.Models;

namespace Testing
{
    public interface IProductRepository
    {
       public IEnumerable<Product> GetAllProducts();
        public Product GetProductById(int id);
        public void UpdateProduct(Product product);
        public void InsertProduct(Product productToInsert);
        public IEnumerable<Category> GetCategories();
        public Product AssignCategory();
    }

}
