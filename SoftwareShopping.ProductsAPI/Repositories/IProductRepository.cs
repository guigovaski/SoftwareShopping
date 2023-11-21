using SoftwareShopping.ProductsAPI.Data.ValueObjects;

namespace SoftwareShopping.ProductsAPI.Repositories;

public interface IProductRepository
{
    Task<List<ProductDto>> FindAllAsync();
    Task<ProductDto> FindByIdAsync(int id);
    Task<ProductDto> AddAsync(ProductDto product);
    Task<ProductDto> UpdateAsync(ProductDto product);
    Task<bool> DeleteAsync(int id);
}
