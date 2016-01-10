using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DigitalAlgorithms;
namespace DigitalSignalProcessing5
{
    public partial class DigitalSignalProcessing : Form
    {
        string path;
        string path2;
        int Index = -1;
        List<double> Signal1;
        List<double> Signal2;
        List<double> signalResult;
        List<double> Normal=new List<double>();
        ConvolutionSum CS = new ConvolutionSum();
        PeriodicSignalCorrelation PS = new PeriodicSignalCorrelation();
        public DigitalSignalProcessing()
        {
            InitializeComponent();
            loadsignal2.Enabled = false;
            loadsinal1.Enabled = false;
            standard.Enabled = false;
            fast.Enabled = false;
        }

        private void DigitalSignalProcessing_Load(object sender, EventArgs e)
        {

        }

        private void loadsinal2_Click(object sender, EventArgs e)
        {
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                path = openfile.FileName.ToString();
                Signal1 = Read.ReadSignal(path);
            }
        }

        private void loadsignal1_Click(object sender, EventArgs e)
        {
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                path2 = openfile.FileName.ToString();
                Signal2 = Read.ReadSignal(path2);
            }
        }
        private void SignalAlgorithms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SignalAlgorithms.SelectedIndex == 0)
            {
                Index = SignalAlgorithms.SelectedIndex;
                loadsinal1.Enabled = true;
                loadsignal2.Enabled = true;
                fast.Enabled = true;
                standard.Enabled = true;
            }
            else if (SignalAlgorithms.SelectedIndex == 1 || SignalAlgorithms.SelectedIndex == 2)
            {
                Index = SignalAlgorithms.SelectedIndex;
                loadsinal1.Enabled = true;
                loadsignal2.Enabled = true;
                fast.Enabled = true;
                standard.Enabled = true;
            }
            else if (SignalAlgorithms.SelectedIndex == 3 || SignalAlgorithms.SelectedIndex == 4)
            {
                Index = SignalAlgorithms.SelectedIndex;
                loadsinal1.Enabled = true;
                loadsignal2.Enabled = false;
                fast.Enabled = true;
                standard.Enabled = true;
            }
            else
            {
                Index = -1;
                loadsinal1.Enabled = false;
                loadsignal2.Enabled = false;
                fast.Enabled = false;
                standard.Enabled = false;
            }
        }

        private void Compute_Click(object sender, EventArgs e)
        {
            ResultSignal.Clear();
            ResultSignalNorlmalized.Clear();
            switch (Index)
            {
                case 0:
                    if (standard.Checked==true)
                    {
                        signalResult = CS.Convolve(Signal1, Signal2, 0, 0);
                    }
                    else if(fast.Checked==true)
                    {
                        signalResult = CS.FastConvolve(Signal1, Signal2, 0, 0);
                    }
                    break;
                case 1:
                    if(standard.Checked==true)
                    {
                        signalResult = PS.CorrelationTwoSignals(Signal1, Signal2,ref Normal);
                    }
                    else if(fast.Checked==true)
                    {
                        signalResult = PS.FastCorrelationTwoSignals(Signal1, Signal2,ref Normal);
                    }
                    break;
                case 3:
                    if(standard.Checked==true)
                    {
                        signalResult = PS.AutoCorrelation(Signal1);
                    }
                    break;
                default:
                    MessageBox.Show("No Algorithm is Running");
                    break;
            }
            for(int j=0;j<signalResult.Count;j++)
            {
                ResultSignal.AppendText(signalResult[j].ToString());
                ResultSignal.AppendText(Environment.NewLine);
            }
            for(int j=0;j<Normal.Count;j++)
            {
                ResultSignalNorlmalized.AppendText(Normal[j].ToString());
                ResultSignalNorlmalized.AppendText(Environment.NewLine);
            }
        }
    }
}
