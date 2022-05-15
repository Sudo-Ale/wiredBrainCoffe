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

                if (selectedData is null)
                {
                    Console.WriteLine("Quarter can't be null, try again..");
                    continue;
                }
                
                var surveyResult = JsonConvert.DeserializeObject<SurveyResults>(File.ReadAllText($"Data/{selectedData}.json"));
                
                if(surveyResult is null)
                {
                    Console.WriteLine("Quarter not found, try again..");
                    continue;
                }

                var task = new Tasks();
                switch (selectedReport)
                {
                    case "rewards":
                        task.WinnerEmails(surveyResult);
                        break;

                    case "comments":
                        task.CommentsReport(surveyResult);
                        break;

                    case "tasks":
                        task.TasksReport(surveyResult);
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