using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuronNetwork.Functions;
using NeuronNetwork.Interfaces;

namespace NeuronNetwork
{
    public class Neuron
    {
        public IActivationFunction Function;
        public double Out;
        public ArrayList In;
        public double BiasWeight;
        public double Error;


        public Neuron()
        {
            Error = 0.0;
            Out = 0.0;
            In = new ArrayList();
            Function = new LogisticCurve();
            BiasWeight = 0.0;
        }

        public Neuron(IActivationFunction f)
        {
            if (f == null) { throw (new Exception("Blad")); }
            Error = 0.0;
            Out = 0.0;
            In = new ArrayList();
            Function = f;
            BiasWeight = 0.0;
        }

        public void AddIn(Neuron N)
        {
            if (N == null) { throw (new Exception("Blad")); };
            In.Add(new Connectivity(N, 1.0));
        }

        public void RandomWeight(double Min, double Max, Random R)
        {
            if ((R == null) || (Max <= Min))
            { throw (new Exception("Blad")); };
            foreach (Connectivity Pol in In)
            {
                Pol.Weight = (R.NextDouble() * (Max - Min)) + Min;
            }
            BiasWeight = (R.NextDouble() * (Max - Min)) + Min;
        }

        public void Calculate()
        {
            Out = 0.0;
            foreach (Connectivity Pol in In)
            {
                Out += Pol.Weight * Pol.N.Out;
            }
            Out += BiasWeight * 1.0;
            Out = Function.Calculate(Out);
        }

        public void CalculateError(double CorrectOut)
        {
            Error = CorrectOut - Out;
        }

        public void CorrectWeight(double WspUczenia)
        {
            if (WspUczenia < 0) { throw (new Exception("Blad")); };
            foreach (Connectivity p in In)
            {
                p.Weight += WspUczenia * Error * Function.CalculateDerivative(Out) * p.N.Out;
            }
            BiasWeight += WspUczenia * Error * Function.CalculateDerivative(Out) * 1.0;
        }

        public void AddIn(Layer W)
        {
            if (W == null) { throw (new Exception("Blad")); };
            foreach (Neuron N in W.Neurony)
            {
                AddIn(N);
            }
        }

        public void RollUpErrorBack()
        {
            foreach (Connectivity p in In)
            {
                p.N.Error += Error * p.Weight;
            }
        }


    }
}
