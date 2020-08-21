using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Xml;

namespace Indicators
{
    class SimpleMovingAverage : MovingAverage
    {
        public SimpleMovingAverage(int parameter) : base(parameter) { }
       
        public override List<double> Calculate(List<double> data)
        {
            // ceknut
            double[] buffer = new double[Parameter];
            List<double> result_simple_moving_average = new List<double>();
            int current_index = 0;
            foreach (double d in data)
            {
                buffer[current_index] = d;
                double simple_moving_average = 0;
                foreach(double b in buffer)
                {
                    simple_moving_average += b;
                }
                result_simple_moving_average.Add(simple_moving_average/(double)Parameter);
                current_index = (current_index + 1) % Parameter;
            }
            
            return result_simple_moving_average;

        }
    }
}
