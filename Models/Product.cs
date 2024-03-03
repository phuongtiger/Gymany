using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gymany.Models
{


public class Product
{
    [Key]
    public int ProductID { get; set; }

    [Required(ErrorMessage = "Product name is required.")]
    [StringLength(50, ErrorMessage = "Product name cannot exceed 50 characters.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Product description is required.")]
    public string Description { get; set; }

    [Required(ErrorMessage = "Product amount is required.")]
    [Range(0, int.MaxValue, ErrorMessage = "Product amount must be a non-negative number.")]
    public int? Amount { get; set; }

    [StringLength(100, ErrorMessage = "Image path cannot exceed 100 characters.")]
    public string Image { get; set; }

    [Required(ErrorMessage = "Product price is required.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "Product price must be a positive number.")]
    public decimal? Price { get; set; }

    [Required(ErrorMessage = "Category ID is required.")]
    public int CategoryID { get; set; }
    public Category Category { get; set; }
}

}