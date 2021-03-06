namespace WiredBrainCoffe
{
    public class SurveyResponse
    {
        public double ServiceScore { get; set; }
        public double CoffeeScore { get; set; }
        public double PriceScore { get; set; }
        public double FoodScore { get; set; }
        public double WouldRecommend { get; set; }

        public string FavoriteProduct { get; set; } = default!;
        public string LeastFavoriteProduct { get; set; } = default!;
        public string AreaToImprove { get; set; } = default!;
        public string EmailAddress { get; set; } = default!;
        public string Comments { get; set; } = default!;
        public string Username { get; set; } = default!;
        
        public bool IsRewardsMember { get; set; }
    }
}