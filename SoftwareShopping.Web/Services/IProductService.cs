using SoftwareShopping.Web.ViewModels;

namespace SoftwareShopping.Web.Services;

public interface IProductService
{
    Task<ProductViewModel> GetByIdAsync(int id);
    Task<IEnumerable<ProductViewModel>> GetAllAsync();
    Task<ProductViewModel> AddAsync(ProductViewModel productVM);
    Task<ProductViewModel> UpdateAsync(ProductViewModel productVM);
    Task<bool> DeleteAsync(int id);
}
