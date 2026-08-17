using System.Collections.Generic;
using AsmitaEnterprises.Models;

namespace AsmitaEnterprises.Services;

public class ProductService
{
    private static readonly List<Product> _staticProducts = new()
    {
        new Product
        {
            Id = "p1",
            NameKey = "Product_RO_Title",
            Name = "RO Water Purifier",
            DescriptionKey = "Product_RO_Desc",
            Description = "Advanced RO technology for pure & safe drinking water.",
            ImageUrl = "images/products/ro-purifier.jpg",
            Category = "RO",
            DisplayOrder = 1
        },
        new Product
        {
            Id = "p2",
            NameKey = "Product_RO_UV_Title",
            Name = "RO + UV",
            DescriptionKey = "Product_RO_UV_Desc",
            Description = "RO + UV purification for extra protection and better health.",
            ImageUrl = "images/products/ro-uv-purifier.jpg",
            Category = "RO+UV",
            DisplayOrder = 2
        },
        new Product
        {
            Id = "p3",
            NameKey = "Product_RO_UV_UF_Title",
            Name = "RO + UV + UF",
            DescriptionKey = "Product_RO_UV_UF_Desc",
            Description = "Complete protection with RO + UV + UF for your family's health.",
            ImageUrl = "images/products/ro-uv-uf-purifier.jpg",
            Category = "RO+UV+UF",
            DisplayOrder = 3
        },
        new Product
        {
            Id = "p4",
            NameKey = "Product_Comm_Title",
            Name = "Commercial RO Systems",
            DescriptionKey = "Product_Comm_Desc",
            Description = "High performance systems for offices, institutions & industries.",
            ImageUrl = "images/products/commercial-ro.jpg",
            Category = "Commercial",
            DisplayOrder = 4
        },
        new Product
        {
            Id = "p5",
            NameKey = "Product_Custom_Title",
            Name = "Customized Water Filter Assembly",
            DescriptionKey = "Product_Custom_Desc",
            Description = "We assemble filters as per your requirement and budget.",
            ImageUrl = "images/products/custom-assembly.jpg",
            Category = "Custom",
            DisplayOrder = 5
        }
    };
    public IEnumerable<Product> GetProducts() => _staticProducts;
}
