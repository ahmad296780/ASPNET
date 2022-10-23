using Dapper;
using System.Collections.Generic;
using System.Data;
using Testing.Models;

namespace Testing
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;
        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("Select * From Products;");
        }

        public Product GetProductById(int id)
        {
            return _conn.QuerySingle<Product>("select * from products where ProductID = @ID", new { id });
        }

        public void UpdateProduct(Product product)
        {
             _conn.Execute("update Products set Name=@name, Price=@price where ProductID=@productID",
                new { name=product.Name, price=product.Price,productID=product.ProductID });
        }
    }
}
