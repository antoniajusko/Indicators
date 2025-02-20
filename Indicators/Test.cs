﻿using System;
using System.Collections.Generic;

namespace Indicators
{
    class Test
    {
        static void Main(string[] args)
        {
            //double[] dataArr = {44.34, 44.09, 44.15, 43.61, 44.33, 44.83, 45.10, 45.42, 45.84, 46.08, 45.89, 46.03, 45.61, 46.28, 46.28, 46.00, 46.03, 46.41, 46.22, 45.64, 46.21, 46.25, 45.71, 46.45, 45.78, 45.35, 44.03, 44.18, 44.22, 44.57, 43.42, 42.66, 43.13 };
            //List<double> data = new List<double> { 12, 13, 14, 15, 16, 17 };
            //int parameter = 5;
            /* List<double> data = new List<double>();
             data.AddRange(dataArr);
             (float, float)ts = (10, 10);

             RelativeStrengthIndex RSI = new RelativeStrengthIndex(parameter, ts);
             List<double> outputRSI = RSI.Calculate(data);
             Console.WriteLine("RSI");
             foreach (double r in outputRSI)
             {
                 Console.WriteLine(r);
             }

             (double, double) lastRSI = RSI.GetLastTwoRSI();
             Console.WriteLine("this is last rsi " + lastRSI.Item2);*/
            List<double> data = new List<double> { 11, 12, 13, 14, 15, 16, 17 };
            int parameter = 5;
            //data.Reverse();

            ExponentialMovingAverage EMA = new ExponentialMovingAverage(parameter);
            List<double> outputEMA = EMA.Calculate(data);
            List<double> expected = new List<double> { 11.5, 11.667, 12.111, 12.741, 13.494, 14.329 };
            //Assert.AreEqual(expected.Count, outputEMA.Count - 1);

            for (int i = 0; i < expected.Count; i++)
            {
                Console.WriteLine(outputEMA[i]);
               // Assert.AreEqual(expected[i], Math.Round(outputEMA[i]), 1, "NOK");
            }
        }


    }
}
