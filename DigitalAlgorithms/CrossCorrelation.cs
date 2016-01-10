using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DigitalAlgorithms
{
    public abstract class CrossCorrelation
    {
        public abstract List<double> AutoCorrelation(List<double>signal);
        public abstract List<double> CorrelationTwoSignals(List<double> signal1, List<double> signal2,ref List<double>NormalizedSignal);
    }
}
