using System;
using System.Collections.Generic;
using System.Text;

namespace Indicators
{
    class RelativeStrengthIndex : Oscillator
    {
        public RelativeStrengthIndex(int parameter, (float, float) thresholds) : base(parameter, thresholds) { }

        public override List<double> Calculate(List<double> data)
        {
            List<double> RSI = new List<double>();
            double sumGain = 0;
            double sumLoss = 0;
            double relativeStrenghtIndex;
            double averageGain = sumGain;
            double averageLoss = sumLoss;

            for (int i = 1; i < data.Count; i++)
            {
                double difference = data[i] - data[i - 1];
                if (i <= Parameter)
                {
                    if (difference >= 0)
                    {
                        sumGain += difference;
                    }
                    else
                    {
                        sumLoss -= difference;
                    }

                    if (i == Parameter)
                    {
                        relativeStrenghtIndex = 100 - (100 / (1 + sumGain / sumLoss));
                        RSI.Add(relativeStrenghtIndex);
                        averageGain = sumGain / Parameter;
                        averageLoss = sumLoss / Parameter;
                    }
                    else RSI.Add(0);
                }
                else
                {
                    if (difference >= 0)
                    {
                        averageGain = ((averageGain * (Parameter - 1)) + difference) / Parameter;
                        averageLoss = (averageLoss * (Parameter - 1)) / Parameter;
                    }
                    else
                    {
                        averageLoss = ((averageLoss * (Parameter - 1)) - difference) / Parameter;
                        averageGain = (averageGain * (Parameter - 1)) / Parameter;
                    }

                    relativeStrenghtIndex = 100 - (100 / (1 + averageGain / averageLoss));

                    RSI.Add(relativeStrenghtIndex);
                }

            }
            resultFromRSI = RSI;
            return resultFromRSI;

        }
        bool IsOverBought(int index = -1)
        {
            double lastRSI = resultFromRSI[resultFromRSI.Count + index];
            if (lastRSI > Thresholds.Item1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool IsOverSold(int index = -1)
        {

            double lastRSI = resultFromRSI[resultFromRSI.Count + index];

            if (lastRSI > Thresholds.Item2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        bool BreakUpOverBought()
        {

            if (IsOverBought() == false && IsOverBought(-2) == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        bool BreakUpOverSold()
        {

            if (IsOverSold() == false && IsOverSold(-2) == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public (double, double) GetLastTwoRSI()
        {
            return (resultFromRSI[resultFromRSI.Count - 1], resultFromRSI[resultFromRSI.Count - 2]);
        }
    }
        
}