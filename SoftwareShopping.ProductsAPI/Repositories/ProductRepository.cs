using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SoftwareShopping.ProductsAPI.Data.Context;
using SoftwareShopping.ProductsAPI.Data.ValueObjects;
using SoftwareShopping.ProductsAPI.Entities;

namespace SoftwareShopping.ProductsAPI.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;

    public ProductRepository(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<ProductDto>> FindAllAsync()
    {
        var products = await _context.Products.ToListAsync();
        return _mapper.Map<List<ProductDto>>(products);
    }

    public async Task<ProductDto> FindByIdAsync(int id)
    {
        var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductId == id);
        return _mapper.Map<ProductDto>(product);
    }

    public async Task<ProductDto> AddAsync(ProductDto product)
    {
        var productRaw = _mapper.Map<Product>(product);
        await _context.Products.AddAsync(productRaw);
        await _context.SaveChangesAsync();
        return _mapper.Map<ProductDto>(productRaw);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductId == id);
        if (product is null) return false;
        _context.Products.Remove(product);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<ProductDto> UpdateAsync(ProductDto product)
    {
        var productRaw = await _context.Products.FirstOrDefaultAsync(p => p.ProductId == product.ProductId);
        if (product is null) return null;
        _context.Products.Update(productRaw);
        await _context.SaveChangesAsync();
        return _mapper.Map<ProductDto>(product);
    }
}
