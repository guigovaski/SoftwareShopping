﻿using AutoMapper;
using SoftwareShopping.ProductsAPI.Entities;

namespace SoftwareShopping.ProductsAPI.Data.ValueObjects;

[AutoMap(typeof(Product), ReverseMap = true)]
public class ProductDto
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
    public string ImageUrl { get; set; }
}
