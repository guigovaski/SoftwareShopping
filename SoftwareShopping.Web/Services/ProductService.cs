using SoftwareShopping.Web.ViewModels;
using System.Net.Http.Json;

namespace SoftwareShopping.Web.Services;

public class ProductService : IProductService
{
    private readonly HttpClient _httpClient;
    private const string BasePath = "api/products";

    public ProductService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ProductViewModel> AddAsync(ProductViewModel productVM)
    {
        var product = await _httpClient.PostAsJsonAsync<ProductViewModel>(BasePath, productVM);
        if (!product.IsSuccessStatusCode)
        {
            throw new ApplicationException("Something went wrong during creating a product");
        }

        var data = await product.Content.ReadFromJsonAsync<ProductViewModel>();

        ArgumentNullException.ThrowIfNull(data);

        return data;
    }

    public async Task<IEnumerable<ProductViewModel>> GetAllAsync()
    {
        var products = await _httpClient.GetFromJsonAsync<IEnumerable<ProductViewModel>>(BasePath);
        ArgumentNullException.ThrowIfNull(products);
        return products;
    }

    public async Task<ProductViewModel> GetByIdAsync(int id)
    {
        var product = await _httpClient.GetFromJsonAsync<ProductViewModel>($"{BasePath}/{id}");
        ArgumentNullException.ThrowIfNull(product);
        return product;
    }

    public async Task<ProductViewModel> UpdateAsync(ProductViewModel productVM)
    {

        var product = await _httpClient.PutAsJsonAsync<ProductViewModel>(BasePath, productVM);
        if (!product.IsSuccessStatusCode)
        {
            throw new ApplicationException("Something went wrong during updating a product");
        }

        var data = await product.Content.ReadFromJsonAsync<ProductViewModel>();

        ArgumentNullException.ThrowIfNull(data);

        return data;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var result = await _httpClient.DeleteAsync($"{BasePath}/{id}");
        if (!result.IsSuccessStatusCode)
        {
            throw new ApplicationException("Something went wrong during deleting a product");
        }
        return true;
    }
}
