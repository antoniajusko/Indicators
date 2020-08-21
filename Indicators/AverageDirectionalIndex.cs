using System;
using System.Collections.Generic;
using System.Text;
//using Broker.FXCM;

namespace Indicators
{
    class AverageDirectionalIndex : Oscillator
    {
        public AverageDirectionalIndex(int parameter, (float, float) thresholds) : base(parameter, thresholds) { }

        public override List<double> Calculate(List<double> data)
        {
            //FxcmData getFxcmData = new FxcmData(FxcmData.FxcmTimeFrames.MIN_5, FxcmData.FxcmInstruments.EUR_USD, 100);
            //getFxcmData.UpdateCandles();
            //List<double> bidClose = getFxcmData.GetAskClosed();
            //List<double> bidHigh = getFxcmData.GetAskHigh();
            //List<double> bidLow = getFxcmData.GetAskLow();

            

            return data;
        }

    }
}
