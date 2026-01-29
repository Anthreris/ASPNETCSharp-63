namespace Testing.Data;

public interface IProductReposistory
{
    public IEnumerable<Product> GetAllProducts();
}