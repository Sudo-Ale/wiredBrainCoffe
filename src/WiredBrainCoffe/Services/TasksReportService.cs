using System;

namespace WiredBrainCoffe
{
    public static class TasksReportService
    {
        public static void GenerateTasksReport(SurveyResults surveyResult)
        {
            var tasks = new List<string>();

            var responseRate = surveyResult.NumberResponded / surveyResult.NumberSurveyed;
            var overallScore = (surveyResult.ServiceScore + surveyResult.CoffeeScore + surveyResult.FoodScore + surveyResult.PriceScore) / 4;

            if (surveyResult.CoffeeScore < surveyResult.FoodScore)
            {
                tasks.Add("Investigate coffee recipes and ingredients.");
            }

            tasks.Add(overallScore > 8.0 ? "Work with leadership to reward staff" : "Work with employees for improvement ideas");

            if (responseRate < .33)
            {
                tasks.Add("Research options to improve response rate");
            }
            else if (responseRate > .33 && responseRate < .66)
            {
                tasks.Add("Reward participants with free coffee coupon");
            }
            else
            {
                tasks.Add("Rewards participants with discount coffee coupon");
            }

            // tasks.Add(responseRate switch 
            // {
            //     var rate when rate < .33 => "Research options to improve response rate",
            //     var rate when rate > .33 && rate < .66 => "Reward participants with free coffee coupon",
            //     var rate when rate > .66 => "Rewards participants with discount coffee coupon",
            //     _ => ""
            // });

            tasks.Add(surveyResult.AreaToImprove switch
            {
                "RewardsProgram" => "Revisit the rewards deal",
                "Cleanliness" => "Contact the cleaning vendor.",
                "MobileApp" => "Contact consulting firm about app",
                _ => "Investigate individual comments for ideas."
            });

            Console.WriteLine(Environment.NewLine + "Tasks output:");
            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }
            Console.WriteLine(Environment.NewLine);

            File.WriteAllLines("Reports/TasksReport.csv", tasks);
        }
    }
}