using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuronNetwork.Interfaces;

namespace NeuronNetwork
{
    public class NeuronNetwork
    {

        public Layer lIn, lOut;
        public Layer[] lHidden;

        public NeuronNetwork(int SizeIn,int SizeHidden,int SizeOut,int CountHidden,IActivationFunction f) {

            if ((SizeIn < 1) || (SizeHidden < 1) ||
                    (SizeOut < 1) || (CountHidden < 1) || (f == null))
            { throw (new Exception("Blad")); };

            lIn = new Layer(SizeIn);
            lOut = new Layer(SizeOut, f);
            lHidden = new Layer[CountHidden];
            for (int i = 0; i < CountHidden; i++)
            { lHidden[i] = new Layer(SizeHidden, f); }

            lOut.ConnectWithLayer(lHidden[CountHidden - 1]);
            for (int i = (CountHidden - 1); i > 0; i--)
            {
                lHidden[i].ConnectWithLayer(lHidden[i - 1]);
            }
            lHidden[0].ConnectWithLayer(lIn);

        }

        public void RandomWeight(double Min, double Max)
        {
            var Rand = new Random();

            lOut.RandowWeight(Min, Max, Rand);
            foreach (var t in lHidden)
            {
                t.RandowWeight(Min, Max, Rand);
            }
        }

        public double[] Calculate(double[] In)
        {
            if ((In == null) ||
                    (In.Length != lIn.Neurony.Count))
            { throw (new Exception("Blad")); };

            lIn.LawsOut(In);
            foreach (var t in lHidden)
            {
                t.Calculate();
            }
            lOut.Calculate();
            return lOut.ReturnOut();
        }

        public void LearningNetwork(double[] CorrectOut, double[] In, double learningCoefficient){

            if ((CorrectOut.Length != lOut.Neurony.Count) ||
                    (In.Length != lIn.Neurony.Count))
            { throw (new Exception("Blad")); };

            lOut.ResetError();
            foreach (var t in lHidden)
            {
                t.ResetError();
            }

            Calculate(In);

            lOut.CalculateErrors(CorrectOut);
            lOut.RollUpErrorsBack();
            for (var i = (lHidden.Length - 1); i > 0; i--)
            { lHidden[i].RollUpErrorsBack(); }

            lOut.CorrectWeights(learningCoefficient);
            foreach (var t in lHidden)
            {
                t.CorrectWeights(learningCoefficient);
            }
        }


    }
}
