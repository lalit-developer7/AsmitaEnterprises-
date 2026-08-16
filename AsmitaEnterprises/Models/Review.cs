namespace AsmitaEnterprises.Models;

public class Review
{
    public string Id { get; set; } = string.Empty;
    public string AuthorName { get; set; } = string.Empty;
    public string Initial { get; set; } = string.Empty;
    public double Rating { get; set; } = 5.0;
    public string TimeAgo { get; set; } = string.Empty;
    public string CommentKey { get; set; } = string.Empty;
    public string Comment { get; set; } = string.Empty;
    public string AvatarBgColor { get; set; } = "#718096";
}
