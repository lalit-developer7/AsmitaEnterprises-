namespace AsmitaEnterprises.Models;

public class ServiceItem
{
    public string Id { get; set; } = string.Empty;
    public string NameKey { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string DescriptionKey { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string IconType { get; set; } = string.Empty;
    public int DisplayOrder { get; set; }
}
