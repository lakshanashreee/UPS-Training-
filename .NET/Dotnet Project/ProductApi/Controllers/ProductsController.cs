
using Microsoft.AspNetCore.Mvc;
using ProductApi.Models;

namespace ProductApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private static readonly List<Product> Products = new()
    {
        new Product
        {
            Id = 1,
            Name = "Keyboard",
            Price = 1200,
            Category = "Electronics"
        },
        new Product
        {
            Id = 2,
            Name = "Mouse",
            Price = 600,
            Category = "Electronics"
        },
        new Product
        {
            Id = 3,
            Name = "Notebook",
            Price = 80,
            Category = "Stationery"
        },
        new Product
        {
            Id = 4,
            Name = "Laptop",
            Price = 99999,
            Category = "Electronics"
        }
    };

    [HttpGet]
    public ActionResult<List<Product>> GetProducts()
    {
        return Ok(Products);
    }

    [HttpGet("{id:int}")]
    public ActionResult<Product> GetProductById(int id)
    {
        var product = Products.FirstOrDefault(p => p.Id == id);

        if (product == null)
        {
            return NotFound();
        }

        return Ok(product);
    }

    [HttpGet("search")]
    public ActionResult<List<Product>> SearchProducts(
        [FromQuery] string category)
    {
        var results = Products
            .Where(p => p.Category.Equals(
                category,
                StringComparison.OrdinalIgnoreCase))
            .ToList();

        return Ok(results);
    }

    [HttpPost]
    public ActionResult<Product> CreateProduct(
        [FromBody] Product product)
    {
        product.Id = Products.Max(p => p.Id) + 1;

        Products.Add(product);

        return CreatedAtAction(
            nameof(GetProductById),
            new { id = product.Id },
            product);
    }
}
