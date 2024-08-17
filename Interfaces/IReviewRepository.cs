using PokReviewApp.Models;

namespace PokReviewApp.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();
        Review GetReview(int reviewId);
        ICollection<Review> GetReviewOfAPokemon(int reviewId);
        bool ReviewExists(int reviewId);
    }
}
