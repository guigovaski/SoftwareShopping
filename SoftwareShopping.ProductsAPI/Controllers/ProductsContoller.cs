using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SoftwareShopping.ProductsAPI.Data.ValueObjects;
using SoftwareShopping.ProductsAPI.Repositories;

namespace SoftwareShopping.ProductsAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductRepository _productsRepository;

    public ProductsController(IProductRepository productsRepository)
    {
        _productsRepository = productsRepository;
    }
    
    [HttpGet]
    public async Task<ActionResult<List<ProductDto>>> GetAll()
    {
        var products = await _productsRepository.FindAllAsync();
        return Ok(products);
    }

    [Authorize]
    [HttpGet("{id:int}")]
    public async Task<ActionResult<ProductDto>> GetById(int id)
    {
        var product = await _productsRepository.FindByIdAsync(id);
        if (product is null) return NotFound();
        return Ok(product);
    }

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> AddProduct(ProductDto productVO)
    {
        if (!ModelState.IsValid) return BadRequest();
        var product = await _productsRepository.AddAsync(productVO);
        return CreatedAtAction(nameof(GetById), new { id = product.ProductId }, product);
    }

    [Authorize]
    [HttpPut]
    public async Task<IActionResult> UpdateProduct(ProductDto productVO)
    {
        var product = await _productsRepository.UpdateAsync(productVO);
        if (product is null) return BadRequest();
        return Ok(product);
    }
    
    [Authorize]
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProduct(int id)
    {
        var result = await _productsRepository.DeleteAsync(id);
        if (!result) return BadRequest();
        return Ok();
    }
}
