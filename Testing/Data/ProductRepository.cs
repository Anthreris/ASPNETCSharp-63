using System.Collections.Generic;
using System.Data;
using Dapper;
using Testing.Models;

namespace Testing.Data;

public class ProductRepository : IProductReposistory
{
    private readonly IDbConnection _connection;

    public ProductRepository(IDbConnection connection)
    {
        _connection = connection;
    }
    
    public IEnumerable<Product> GetAllProducts()
    {
        return _connection.Query<Product>("SELECT * FROM products");
    }
}