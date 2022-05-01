using System;

namespace WiredBrainCoffe
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = new Tasks();
            task.TestReports();
            Console.WriteLine();

            for(var i = 0; i < Q1Results.Responses.Count; i++)
            {
                var currentResponse = Q1Results.Responses[i];

                if(currentResponse.WouldRecommend < 7.0)
                {
                    Console.WriteLine(currentResponse.Comments);
                }
            }
        }
    }
}