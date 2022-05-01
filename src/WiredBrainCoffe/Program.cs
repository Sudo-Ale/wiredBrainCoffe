using System;

namespace WiredBrainCoffe
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = new Tasks();
            task.TasksReport();
            task.CommentsReport();
            task.WinnerEmails();
        }
    }
}