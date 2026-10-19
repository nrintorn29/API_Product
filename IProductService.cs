public interface IProductService
{
    List<Product> GetAll();
    Product? GetById(int id);
    Product Create(Product newProduct);
    List<Product> Search(string name);
    Product? Update(int id, Product updateProduct);
    bool Delete(int id);
    void DeleteAll();
    List<Product> GetExpensive(decimal minPrice);
}