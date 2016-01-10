using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DigitalAlgorithms
{
    public class Complex
    {
        public double real = 0.0f;
        public double imag = 0.0f;
        // Empty Constructor
        public Complex()
        {

        }
        public Complex (double real,double imag)
        {
            this.real = real;
            this.imag = imag;
        }
        // To Convert Complex number to string 
        public string ToString()
        {
            string data = this.real.ToString() + "" + this.imag.ToString();
            return data;
        }
        // Convert Ploar to rectangular
        public static Complex from_polar(double r,double radians)
        {
            Complex data = new Complex(r * Math.Cos(radians), r * Math.Sin(radians));
            return data;
        }
        // override addition operator
        public static Complex operator +(Complex a,Complex b)
        {
            Complex data = new Complex(a.real + b.real, a.imag + b.imag);
            return data;
        }
        // override subtraction operator
        public static Complex operator-(Complex a,Complex b)
        {
            Complex data = new Complex(a.real - b.real, a.imag - b.imag);
            return data;
        }
        //override Multiplication operator
        public static Complex operator*(Complex a,Complex b)
        {
            Complex data = new Complex((a.real * b.real) - (a.imag * b.imag), (a.real * b.imag) + (a.imag * b.real));
            return data;
        }
        // Return Magnitude of complex number
        public double magnitude
        {
            get
            {
                return Math.Sqrt(Math.Pow(real, 2) + Math.Pow(imag, 2));
            }
        }
        public double phase
        {
            get
            {
                return Math.Atan(imag / real);
            }
        }
    }
}
