using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace DigitalSignalProcessing5
{
    public class Read
    {
        public static List<double>ReadSignal(string Path)
        {
            string str;
            List<double> Result = new List<double>();
            FileStream fsread = new FileStream(Path, FileMode.Open);
            StreamReader sr = new StreamReader(fsread);
            // Peek returns the next character to be read, -1 if no more.
            // It does not change the current position of the StreamReader. 
            while (sr.Peek() > -1)
            {
                str = sr.ReadLine();
                Result.Add(Convert.ToDouble(str));
            }
            sr.Close();
            return Result;
        }
    }
}
