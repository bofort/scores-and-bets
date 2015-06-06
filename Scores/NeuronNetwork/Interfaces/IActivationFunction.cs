using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuronNetwork.Interfaces
{
    public interface IActivationFunction
    {

        double Calculate(double In);
        double CalculateDerivative(double Out);

    }
}
