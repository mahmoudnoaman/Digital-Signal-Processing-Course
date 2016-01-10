using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DigitalAlgorithms
{
    public class ConvolutionSum
    {
        /// <summary>
        /// this function is used to calculate the convolution sum between two signals
        /// </summary>
        /// <param name="H">H is List Which Conatain H(k) </param>
        /// <param name="X">X Is the List which Conatin The original signal </param>
        /// <param name="OrignX">where the Head of Signal origin resides</param>
        /// <param name="OriginH">where Head of result signal origin resides</param>
        /// <returns>Convolution Sum between two signals</returns>
        public List<double> Convolve(List<double> H, List<double> X, int OrignX, int OriginH)
        {
            int TempH, TempX;
            int OldCount = H.Count;
            List<double> Result = new List<double>();
            List<double> FoldedH = Folding(H);
            double ComulativeSum = 0;
            int FoldedIndex = H.Count - (OriginH + 1);
            TempH = FoldedIndex;
            TempX = OrignX;
            double Temp = 0;
            /**
             * shift Right
             */
            while (true)
            {
                int MinIndex = X.Count - OrignX;
                while (MinIndex != 0)
                {
                    Temp = (TempH < FoldedH.Count) ? FoldedH[TempH] : 0;
                    ComulativeSum += Temp * X[TempX];
                    MinIndex--;
                    TempH++;
                    TempX++;
                }
                Result.Add(ComulativeSum);
                ComulativeSum = 0;
                TempH = FoldedIndex;
                TempX = OrignX;
                FoldedH.Insert(0, 0);
                if (FoldedH.Count > 3 * OldCount)
                    break;
            }
            /*
             * shift Left
             */
            FoldedH.Clear();
            FoldedH = Folding(H);
            FoldedIndex = H.Count - (OriginH + 1);
            TempH = FoldedIndex + 1;
            TempX = OrignX;
            while (true)
            {
                int MinIndex = X.Count - OrignX;
                while (MinIndex != 0)
                {
                    Temp = (TempH < FoldedH.Count) ? FoldedH[TempH] : 0;
                    ComulativeSum += Temp * X[TempX];
                    MinIndex--;
                    TempH++;
                    TempX++;
                }
                Result.Insert(0, ComulativeSum);
                ComulativeSum = 0;
                TempH++;
                TempX = OrignX;
                if (TempH >= FoldedH.Count)
                {
                    Result.Insert(0, 0);
                    Result.Insert(0, 0);
                    break;
                }
            }
            return Result;
        }
        private List<double> Folding(List<double> H)
        {
            List<double> TempH = new List<double>();
            for (int j = H.Count - 1; j >= 0; j--)
            {
                TempH.Add(H[j]);
            }
            return TempH;
        }
        public List<double> FastConvolve(List<double> H, List<double> X, int OrignX, int OriginH)
        {
            int TempH, TempX;
            int OldCount = H.Count;
            List<double> Result = new List<double>();
            List<double> FoldedH = Folding(H);
            double ComulativeSum = 0;
            int FoldedIndex = H.Count - (OriginH + 1);
            TempH = FoldedIndex;
            TempX = OrignX;
            double Temp = 0;
            Complex[] S1;
            Complex[] S2;
            Complex[] S11;
            Complex[] S22;
            Complex[] ResultSignal;
            int Size = X.Count;
            S1 = new Complex[Size];
            S2 = new Complex[Size];
            ResultSignal = new Complex[Size];
            for (int j = 0; j < Size; j++)
            {
                S1[j] = new Complex(0, 0);
                S2[j] = new Complex(0, 0);
                S1[j].real = H[j];
                S2[j].real = X[j];
            }
            S11 = Fourier.FFT(S1);
            S22 = Fourier.FFT(S2);
            for (int j = 0; j < Size; j++)
            {
                ResultSignal[j] = S11[j] * S22[j];
            }
            S1 = Fourier.IFFT(ResultSignal);
            for (int i = 0; i < Size; i++)
            {
                Result.Add(S1[i].real / Size);
            }
            return Result;
        }
    }
}
