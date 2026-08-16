namespace AsmitaEnterprises.Models;

public class Product
{
    public string Id { get; set; } = string.Empty;
    public string NameKey { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string DescriptionKey { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;
    public int DisplayOrder { get; set; }
}
