using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuronNetwork
{
    public class Connectivity
    {

        public Neuron N;
        public double Weight;

        public Connectivity(Neuron N, double W)
        {
            if (N == null) { throw (new Exception("Blad")); }
            this.N = N;
            Weight = W;
        }

    }
}
