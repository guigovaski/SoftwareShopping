using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoftwareShopping.ProductsAPI.Entities;

public class Product
{
    public int ProductId { get; set; }
    
    [Required]
    [StringLength(200)]
    [Column("name")]
    public string Name { get; set; }

    [Required]
    [StringLength(500)]
    [Column("description")]
    public string Description { get; set; }

    [Required]
    [Range(1, 10000)]
    [Column("price")]
    public decimal Price { get; set; }

    [Required]
    [StringLength(300)]
    [Column("category")]
    public string Category { get; set; }

    [Required]
    [StringLength(300)]
    [Column("image_url")]
    public string ImageUrl { get; set; }
}
