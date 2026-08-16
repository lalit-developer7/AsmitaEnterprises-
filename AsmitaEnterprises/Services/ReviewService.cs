using System.Collections.Generic;
using AsmitaEnterprises.Models;

namespace AsmitaEnterprises.Services;

public class ReviewService
{
    private static readonly List<Review> _staticReviews = new()
    {
        new Review
        {
            Id = "r1",
            AuthorName = "Prakash Deshmukh",
            Initial = "P",
            Rating = 5.0,
            TimeAgo = "2 weeks ago",
            Comment = "Excellent service and good product quality. Installation was done perfectly. Very happy!",
            AvatarBgColor = "#718096"
        },
        new Review
        {
            Id = "r2",
            AuthorName = "Sneha Patil",
            Initial = "S",
            Rating = 5.0,
            TimeAgo = "1 month ago",
            Comment = "Very professional team. Demo was very helpful in choosing the right filter for our home.",
            AvatarBgColor = "#3182ce"
        },
        new Review
        {
            Id = "r3",
            AuthorName = "Rohit Sharma",
            Initial = "R",
            Rating = 5.0,
            TimeAgo = "1 month ago",
            Comment = "Best quality water filters at reasonable price. Free servicing is a big plus. Highly recommended!",
            AvatarBgColor = "#2b6cb0"
        }
    };

    public IEnumerable<Review> GetReviews() => _staticReviews;
}
