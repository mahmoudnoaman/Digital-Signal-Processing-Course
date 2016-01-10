using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DigitalAlgorithms
{
    public class PeriodicSignalCorrelation :CrossCorrelation
    {
        public override List<double> AutoCorrelation(List<double> signal)
        {
            List<double> Result = new List<double>();
            List<double> TempSignal = new List<double>();
            int Count = signal.Count;
            double CorrelationSum = 0;
            double LocalSum;
            for (int j = 0; j < signal.Count;j++ )
            {
                TempSignal.Add(signal[j]);
            }
            while (true)
            {
                LocalSum = 0;
                for (int j = 0; j < signal.Count; j++)
                {
                    LocalSum += (TempSignal[j] * signal[j]);
                }
                Result.Add(LocalSum / signal.Count);
                CorrelationSum += LocalSum;
                TempSignal.Add(TempSignal[0]);
                TempSignal.RemoveAt(0);
                Count--;
                if (Count <= 0)
                    break;
            }
            return Result;
        }
        public override List<double> CorrelationTwoSignals(List<double> signal1, List<double> signal2, ref List<double> NormalizedSignal)
        {
            List<double> Result = new List<double>();
            double CorrelationSum = 0;
            double LocalSum;
            int Count;
            int Size = signal1.Count;
            if (signal1.Count != signal2.Count)
            {
                Size = (signal1.Count + signal2.Count) - 1;
                for (int j = signal1.Count; j < Size; j++)
                {
                    signal1.Add(0);
                }
                for (int j = signal2.Count; j < Size; j++)
                {
                    signal2.Add(0);
                }
            }
            Count = Size;
            double Normalizefactor = NormalizingFactor(signal1, signal2);
            while (true)
            {
                LocalSum = 0;
                for (int j = 0; j < signal1.Count; j++)
                {
                    LocalSum += (signal1[j] * signal2[j]);
                }
                Result.Add(LocalSum );
                NormalizedSignal.Add((LocalSum / Size) / Normalizefactor);
                CorrelationSum += LocalSum;
                signal2.Add(signal2[0]);
                signal2.RemoveAt(0);
                Count--;
                if (Count <= 0)
                    break;
            }
            return Result;
        }
        private double NormalizingFactor(List<double>signal1,List<double>signal2)
        {
            double factor1=0;
            double factor2=0;
            for(int j=0;j<signal1.Count;j++)
            {
                factor1 += (signal1[j] * signal1[j]);
                factor2 += (signal2[j] * signal2[j]);
            }
            return (Math.Sqrt(factor1 * factor2))/signal1.Count;
        }
        public  List<double> FastCorrelationTwoSignals(List<double> signal1, List<double> signal2, ref List<double> NormalizedSignal)
        {
            int Count;
            Complex[] S1;
            Complex[] S2;
            Complex[] S11;
            Complex[] S22;
            Complex[] ResultSignal;
            List<double> Result = new List<double>();
            int Size = signal1.Count;
            if (signal1.Count != signal2.Count)
            {
                Size = (signal1.Count + signal2.Count) - 1;
                for (int j = signal1.Count; j < Size; j++)
                {
                    signal1.Add(0);
                }
                for (int j = signal2.Count; j < Size; j++)
                {
                    signal2.Add(0);
                }
            }
            S1 = new Complex[Size];
            S2 = new Complex[Size];
            ResultSignal = new Complex[Size];
            for(int j=0;j<Size;j++)
            {
                S1[j] = new Complex(0,0);
                S2[j] = new Complex(0,0);
                S1[j].real = signal1[j];
                S2[j].real = signal2[j];
            }
            S11 = Fourier.FFT(S1);
            S22 = Fourier.FFT(S2);
            for(int j=0;j<Size;j++)
            {
                S11[j].imag *= -1;
            }
            for(int j=0;j<Size;j++)
            {
                ResultSignal[j] = S11[j] * S22[j];
            }
            S1=Fourier.IFFT(ResultSignal);
            for(int i=0;i<Size;i++)
            {
                Result.Add((S1[i].real / Size)/Size);
            }
            return Result;
        }
    }
}
