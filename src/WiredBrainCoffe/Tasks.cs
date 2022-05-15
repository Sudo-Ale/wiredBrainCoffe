using System;

namespace WiredBrainCoffe
{
    class Tasks
    {
        public void CommentsReport(SurveyResults surveyResult)
        {
            var comments = new List<string>();
            
            Console.WriteLine(Environment.NewLine + "Not would recommend comments:");
            for (var i = 0; i < surveyResult.Responses.Count; i++)
            {
                var currentResponse = surveyResult.Responses[i];

                if (currentResponse.WouldRecommend < 7.0)
                {
                    Console.WriteLine(currentResponse.Comments);
                    comments.Add(currentResponse.Comments);
                }
            }

            Console.WriteLine(Environment.NewLine + "Mobile app to improve comments:");
            foreach (var response in surveyResult.Responses)
            {
                if (response.AreaToImprove == surveyResult.AreaToImprove)
                {
                    Console.WriteLine(response.Comments);
                    comments.Add(response.Comments);
                }
            }
            Console.WriteLine(Environment.NewLine);
            
            File.WriteAllLines("Reports/CommentsReport.csv", comments);
        }
        public void WinnerEmails(SurveyResults surveyResult)
        {
            var selectedEmail = new List<string>();
            int counter = 0;

            
            Console.WriteLine(Environment.NewLine + "Free grift card to:");
            while (selectedEmail.Count < 2 && counter < surveyResult.Responses.Count)
            {
                var currentItem = surveyResult.Responses[counter];

                //winners!!
                if (currentItem.IsRewardsMember)
                {
                    selectedEmail.Add(currentItem.EmailAddress);
                    Console.WriteLine(currentItem.EmailAddress);
                }
                counter++;
            }
            Console.WriteLine(Environment.NewLine);

            File.WriteAllLines("Reports/WinnersReport.csv", selectedEmail);
        }
        public void TasksReport(SurveyResults surveyResult)
        {
            var tasks = new List<string>();

            var responseRate = surveyResult.NumberResponded / surveyResult.NumberSurveyed;
            var overallScore = (surveyResult.ServiceScore + surveyResult.CoffeeScore + surveyResult.FoodScore + surveyResult.PriceScore) / 4;

            if (surveyResult.CoffeeScore < surveyResult.FoodScore)
            {
                tasks.Add("Investigate coffee recipes and ingredients.");
            }

            if (overallScore > 8.0)
            {
                tasks.Add("Work with leadership to reward staff");
            }
            else
            {
                tasks.Add("Work with employees for improvement ideas");
            }

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

            switch (surveyResult.AreaToImprove)
            {
                case "RewardsProgram":
                    tasks.Add("Revisit the rewards deal");
                    break;

                case "Cleanliness":
                    tasks.Add("Contact the cleaning vendor.");
                    break;

                case "MobileApp":
                    tasks.Add("Contact consulting firm about app");
                    break;

                default:
                    tasks.Add("Investigate individual comments for ideas.");
                    break;
            }

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