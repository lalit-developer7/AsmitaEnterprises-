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
            AuthorName = "Mandage Parag",
            Initial = "P",
            Rating = 5.0,
            TimeAgo = "2 weeks ago",
            Comment = "Excellent service experience. Sir arrived on time, checked the water purifier thoroughly, replaced the required parts, and ensured proper functioning before leaving. He also explained the maintenance tips clearly. Highly recommended.",
            AvatarBgColor = "#718096"
        },
        new Review
        {
            Id = "r2",
            AuthorName = "Omkar Patil",
            Initial = "S",
            Rating = 5.0,
            TimeAgo = "1 month ago",
            Comment = "Great service by Asmita Water Solutions. The water purifier installation was quick and professional. The machine is working perfectly and the person was polite and helpful. Highly satisfied.",
            AvatarBgColor = "#3182ce"
        },
        new Review
        {
            Id = "r3",
            AuthorName = "Mahesh Raykar",
            Initial = "R",
            Rating = 5.0,
            TimeAgo = "1 month ago",
            Comment = "I have been using this water filter along with their service for the past 9 years. The water quality has been consistently good, and Mr. Anil Mahajan sir is prompt and professional. Maintenance and part replacements are handled smoothly. Highly satisfied with the product and service.",
            AvatarBgColor = "#2b6cb0"
        }
    };

    public IEnumerable<Review> GetReviews() => _staticReviews;
}
