using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuronNetwork.Interfaces;

namespace NeuronNetwork.Functions
{
    public class LogisticCurve : IActivationFunction
    {

        public double Beta;

        public LogisticCurve()
        {
            Beta = 1.0;
        }

        public LogisticCurve(double B)
        {
            Beta = B;
        }

        public double Calculate(double In)
        {
            return (1.0 / (1.0 + Math.Pow(Math.E, -(Beta * In))));
        }

        public double CalculateDerivative(double Out)
        {
            return Out * (1.0 - Out);
        }

    }
}
