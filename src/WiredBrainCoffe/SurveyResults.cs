using System;

namespace WiredBrainCoffe
{
    public class SurveyResults
    {
        // Aggregate ratings
        public double ServiceScore { get; set; }
        public double CoffeeScore { get; set; }
        public double PriceScore { get; set; }
        public double FoodScore { get; set; }
        public double WouldRecommend { get; set; }
        public string FavoriteProduct { get; set; } = default!;
        public string LeastFavoriteProduct { get; set; } = default!;
        public string AreaToImprove { get; set; } = default!;

        // Aggregate counts
        public double NumberSurveyed { get; set; }
        public double NumberResponded { get; set; }
        public double NumberRewardsMembers { get; set; }

        //Survey Responses
        public List<SurveyResponse> Responses { get; set; } = default!;
    }
}