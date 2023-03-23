using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductManagement
    {
        public static void RetriveTopRecords(List<ProductReview> list)
        {
            Console.WriteLine("Using LINQ method Syntax");
            List<ProductReview> sortInDesending = list.OrderByDescending(p => p.Rating).Take(3).ToList();
            Program.DisplayProductReviews(sortInDesending);

            Console.WriteLine("Using LINQ Query Syntax");
            List<ProductReview> topResults = (from product in list orderby product.Rating descending select product).Take(3).ToList();
            Program.DisplayProductReviews(topResults);
        }
        public static void FetchRecordsBasedOnRatingAndProductId(List<ProductReview> list)
        {
            List<ProductReview> result = list.Where(p => p.Rating > 3 && (p.ProductId == 1 || p.ProductId == 4 || p.ProductId == 9)).ToList();
            Program.DisplayProductReviews(result);
        }
        public static void FindingEachCountOfProductId(List<ProductReview> list)
        {
            var result = list.GroupBy(p => p.ProductId).Select(p => new { Id = p.Key, count = p.Count() }).ToList();
            foreach (var item in result)
            {
                Console.WriteLine("ProductId: " + item.Id + " ->  " + "Count: " + item.count);
            }
        }
    }
}
