using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuronNetwork.Interfaces;

namespace NeuronNetwork
{
    public class Layer
    {

        public ArrayList Neurony;

        public Layer(int CountN)
        {
            if (CountN < 1) { throw (new Exception("Blad")); }
            Neurony = new ArrayList();
            for (var i = 0; i < CountN; i++)
            {
                AddNeuron(new Neuron());
            }
        }

        public Layer(int CountN, IActivationFunction f)
        {
            if ((CountN < 1) || (f == null))
            { throw (new Exception("Blad")); }
            Neurony = new ArrayList();
            for (var i = 0; i < CountN; i++)
            {
                AddNeuron(new Neuron(f));
            }
        }

        public void AddNeuron(Neuron N)
        {
            if (N == null) { throw (new Exception("Blad")); };
            Neurony.Add(N);
        }

        public void ConnectWithLayer(Layer W)
        {
            if (W == null) { throw (new Exception("Blad")); };
            foreach (Neuron N in Neurony)
            {
                N.AddIn(W);
            }
        }

        public void RandowWeight(double Min, double Max, Random R)
        {
            if (R == null) { throw (new Exception("Blad")); };
            foreach (Neuron N in Neurony)
            {
                N.RandomWeight(Min, Max, R);
            }
        }

        public void LawsOut(double[] Out)
        {
            if ((Out == null) || (Out.Length != Neurony.Count))
            { throw (new Exception("Blad")); };
            for (var i = 0; i < Neurony.Count; i++)
            {
                ((Neuron)Neurony[i]).Out = Out[i];
            }
        }

        public double[] ReturnOut()
        {
            double[] Wy = new double[Neurony.Count];
            for (var i = 0; i < Neurony.Count; i++)
            {
                Wy[i] = ((Neuron)Neurony[i]).Out;
            }
            return Wy;
        }

        public void Calculate()
        {
            foreach (Neuron N in Neurony)
            {
                N.Calculate();
            }
        }

        public void ResetError()
        {
            foreach (Neuron N in Neurony)
            {
                N.Error = 0.0;
            }
        }

        public void CalculateErrors(double[] CorrectOut)
        {
            if (CorrectOut.Length != Neurony.Count)
            { throw (new Exception("Blad")); };
            for (var i = 0; i < Neurony.Count; i++)
            {
                ((Neuron)Neurony[i]).CalculateError(CorrectOut[i]);
            }
        }

        public void CorrectWeights(double learningCoefficient)
        {
            if (learningCoefficient < 0) { throw (new Exception("Blad")); };
            foreach (Neuron N in Neurony)
            {
                N.CorrectWeight(learningCoefficient);
            }
        }

        public void RollUpErrorsBack()
        {
            foreach (Neuron N in Neurony)
            {
                N.RollUpErrorBack();
            }
        }

    }
}
