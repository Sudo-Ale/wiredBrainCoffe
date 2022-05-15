using System;

namespace WiredBrainCoffe
{
    public static class CommentsReportService
    {
        public static void GenerateCommentsReport(SurveyResults surveyResult)
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
    }
}