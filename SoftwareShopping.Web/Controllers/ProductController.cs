using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SoftwareShopping.Web.Models;
using SoftwareShopping.Web.Services;
using SoftwareShopping.Web.ViewModels;

namespace SoftwareShopping.Web.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;    
    private readonly IProductService _productService;

    public ProductController(ILogger<ProductController> logger, IProductService productService)
    {
        _productService = productService;
        _logger = logger;
    }
    
    public async Task<IActionResult> Index()
    {
        try
        {
            var products = await _productService.GetAllAsync();
            return View(products);
        }
        catch (ArgumentNullException ex)
        {
            return View();
        }
    }
    
    public async Task<IActionResult> Edit(int id)
    {
        var product = await _productService.GetByIdAsync(id);
        return product is null ? NotFound() : View(product);
    }
    
    [Authorize]
    [HttpPost]
    public async Task<IActionResult> Edit(ProductViewModel productViewModel)
    {
        var product = await _productService.UpdateAsync(productViewModel);
        return product is null ? View(productViewModel) : RedirectToAction(nameof(Index));
    }
    
    public async Task<IActionResult> Delete(int id)
    {
        var product = await _productService.GetByIdAsync(id);
        return product is null ? NotFound() : View(product);  
    }
    
    [Authorize]
    [HttpPost]
    public async Task<IActionResult> DeletePost(int id)
    {
        var product = await _productService.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Add()
    {
        return View();
    }
    
    [Authorize]
    [HttpPost]
    public async Task<IActionResult> Add(ProductViewModel productViewModel)
    {
        var product = await _productService.AddAsync(productViewModel);
        if (product is null)
        {
            return View(productViewModel);
        }
        return RedirectToAction(nameof(Index));
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}