using System;
using System.Text.Json;
using Newtonsoft.Json;

namespace WiredBrainCoffe
{
    class Program
    {
        static void Main(string[] args)
        {
            var quitApp = false;

            do
            {
                Console.WriteLine("Please specify a report to run (rewards, comments, tasks, quit):");
                var selectedReport = Console.ReadLine();

                Console.WriteLine("Please specify which quarter of data: (q1, q2)");
                var selectedData = Console.ReadLine();
                
                var surveyResult = JsonConvert.DeserializeObject<SurveyResults>(File.ReadAllText($"Data/{selectedData}.json"));
                
                if(surveyResult is null)
                {
                    Console.WriteLine("Quarter not found, try again..");
                    continue;
                }

                switch (selectedReport)
                {
                    case "rewards":
                        RewardsReportService.GenerateWinnerEmails(surveyResult);
                        break;

                    case "comments":
                        CommentsReportService.GenerateCommentsReport(surveyResult);
                        break;

                    case "tasks":
                        TasksReportService.GenerateTasksReport(surveyResult);
                        break;

                    case "quit":
                        quitApp = true;
                        Console.WriteLine("Closing application...");
                        break;

                    default:
                        Console.WriteLine("Sorry, that's not a valid option.");
                        break;
                }
            } while (!quitApp);
        }
    }
}