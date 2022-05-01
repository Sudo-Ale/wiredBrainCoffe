using System;

namespace WiredBrainCoffe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculated Values
            var responseRate = Q1Results.NumberResponded / Q1Results.NumberSurveyed;
            var unanswaredCount = Q1Results.NumberSurveyed - Q1Results.NumberResponded;
            var overallScore = (Q1Results.ServiceScore + Q1Results.CoffeeScore + Q1Results.FoodScore + Q1Results.PriceScore) / 4;

            Console.WriteLine($"Response Percentage: {responseRate}");
            Console.WriteLine($"Unanswared Surveys: {unanswaredCount}");
            Console.WriteLine($"Overall score: {overallScore}");

            //Logical Comparisons
            var higherCoffeeScore = Q1Results.CoffeeScore > Q1Results.FoodScore;
            var customersRecommend = Q1Results.WouldRecommend >= 7;
            var noGranolaYesCapuccino = Q1Results.LeastFavoriteProduct == "Granola" && Q1Results.FavoriteProduct == "Cappucino";

            Console.WriteLine($"Coffee Score Higher Than Food: {higherCoffeeScore}");
            Console.WriteLine($"Customers Would Recommend Us: {customersRecommend}");
            Console.WriteLine($"Hate Granola, Love Capuccino: {noGranolaYesCapuccino}");
        }
    }
}