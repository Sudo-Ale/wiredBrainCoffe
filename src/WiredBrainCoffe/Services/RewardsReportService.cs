using System;

namespace WiredBrainCoffe
{
    public static class RewardsReportService
    {
        public static void GenerateWinnerEmails(SurveyResults surveyResult)
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
    }
}