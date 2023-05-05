using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35_ProductReviewManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review managament program ");

            List<ProductReview> Product;
            Product = new List<ProductReview>
            {
                new ProductReview() { ProductId = 10, UserId = 13, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 70, UserId = 16, Rating = 2, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 30, UserId = 111, Rating = 1, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 80, UserId = 167, Rating = 5, Review = "good", isLike = true },
                new ProductReview() { ProductId = 20, UserId = 13, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 60, UserId = 15, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 10, UserId = 19, Rating = 1, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 80, UserId = 12, Rating = 2, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 50, UserId = 16, Rating = 3, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 40, UserId = 111, Rating = 2, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 100, UserId = 178, Rating = 1, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 30, UserId = 123, Rating = 3, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 90, UserId = 18, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 20, UserId = 11, Rating = 5, Review = "good", isLike = true },
                new ProductReview() { ProductId = 70, UserId = 16, Rating = 5, Review = "good", isLike = true },
                new ProductReview() { ProductId = 10, UserId = 19, Rating = 5, Review = "good", isLike = true },
                new ProductReview() { ProductId = 90, UserId = 12, Rating = 2, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 40, UserId = 15, Rating = 1, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 60, UserId = 11, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 20, UserId = 15, Rating = 1, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 80, UserId = 19, Rating = 5, Review = "good", isLike = true },
                new ProductReview() { ProductId = 30, UserId = 19, Rating = 5, Review = "good", isLike = true },
                new ProductReview() { ProductId = 50, UserId = 11, Rating = 2, Review = "bad", isLike = false },
                new ProductReview() { ProductId = 60, UserId = 25, Rating = 3, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 90, UserId = 19, Rating = 1, Review = "bad", isLike = false }
            };

        }
    }
}
