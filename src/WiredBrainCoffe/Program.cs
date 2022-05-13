using System;

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

                var task = new Tasks();
                switch (selectedReport)
                {
                    case "rewards":
                        task.WinnerEmails();
                        break;

                    case "comments":
                        task.CommentsReport();
                        break;

                    case "tasks":
                        task.TasksReport();
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