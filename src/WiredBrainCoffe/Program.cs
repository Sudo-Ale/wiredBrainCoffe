﻿using System;

namespace WiredBrainCoffe
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasks = new List<string>();
            //Calculated Values
            var responseRate = Q1Results.NumberResponded / Q1Results.NumberSurveyed;
            var overallScore = (Q1Results.ServiceScore + Q1Results.CoffeeScore + Q1Results.FoodScore + Q1Results.PriceScore) / 4;

            if(Q1Results.CoffeeScore < Q1Results.FoodScore)
            {
                tasks.Add("Investigate coffee recipes and ingredients");
            }

            if(overallScore > 8.0)
            {
                tasks.Add("Work with leadership to reward staff");
            }
            else
            {
                tasks.Add("Work with employees for improvement ideas");
            }
        }
    }
}