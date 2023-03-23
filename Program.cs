
using System;
using System.Linq;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            List<ProductReview> list = new List<ProductReview>()
            {
                new ProductReview(){ProductId=1,UserId= 1,Rating =7,Review="good",isLike=true},
                new ProductReview(){ProductId=1,UserId= 14,Rating =3,Review="good",isLike=true},
                new ProductReview(){ProductId=3,UserId= 10,Rating =2,Review="good",isLike=true},
                new ProductReview(){ProductId=4,UserId= 7,Rating =1,Review="nice",isLike=true},
                new ProductReview(){ProductId=9,UserId= 3,Rating =5,Review="bad",isLike=false},
                new ProductReview(){ProductId=2,UserId= 16,Rating =4,Review="good",isLike=false},
                new ProductReview(){ProductId=7,UserId= 9,Rating =4,Review="worst",isLike=true},
                new ProductReview(){ProductId=4,UserId= 8,Rating =1,Review="good",isLike=true},
                new ProductReview(){ProductId=9,UserId= 5,Rating =3,Review="good",isLike=false},
                new ProductReview(){ProductId=2,UserId= 45,Rating =3,Review="good",isLike=true},
                new ProductReview(){ProductId=4,UserId= 7,Rating =6,Review="nice",isLike=true},
                new ProductReview(){ProductId=9,UserId= 10,Rating =5,Review="good",isLike=true}
            };
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Please Select options");
                Console.WriteLine("1.Display all data \n2.Retrive Top 3 Records \n3.Fetch Records based on Rating and ProductId \n22.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Displaying all the data");
                        DisplayProductReviews(list);
                        break;
                    case 2:
                        ProductManagement.RetriveTopRecords(list);
                        break;
                    case 3:
                        ProductManagement.FetchRecordsBasedOnRatingAndProductId(list);
                        break;
                    case 22:
                        flag= false;
                        break;
                    default:
                        Console.WriteLine("select the valid options");
                        break;
                }
            }
        }
        public static void DisplayProductReviews(List<ProductReview> list)
        {
            foreach (ProductReview productReview in list)
            {
                Console.WriteLine("ProductID= " + productReview.ProductId + " UserId= " + productReview.UserId + " Rating= " + productReview.Rating + " Review=" + productReview.Review + " isLike=" + productReview.isLike);
            }
        }
    }
}
