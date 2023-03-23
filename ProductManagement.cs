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
    }
}
