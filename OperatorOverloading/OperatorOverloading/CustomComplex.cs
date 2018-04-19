using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class CustomComplex
    {
        private double _imaginary;
        private double _valid;

        public double Imaginary
        {
            get { return _imaginary; }
            set { _imaginary = value; }
        }

        public double Valid
        {
            get { return _valid; }
            set
            { _valid = value; }
        }

        public CustomComplex(double im, double val)
        {
            Imaginary = im;
            Valid = val;
        }

        public override string ToString()
        {
            return "{Imaginary} + i{Valid}";
        }

        public static CustomComplex operator+ (CustomComplex a, CustomComplex b)
        {
            return new CustomComplex(a._valid + b._valid ,a._imaginary + b._imaginary);
        }

        public static CustomComplex operator -(CustomComplex a, CustomComplex b)
        {
            return new CustomComplex(a._valid - b._valid ,a._imaginary - b._imaginary);
        }

        public static CustomComplex operator /(CustomComplex a, CustomComplex b)
        {
            return new CustomComplex((a._valid * b._valid + a._imaginary * b._imaginary)/(b._valid* b._valid + b._imaginary* b._imaginary),((b._valid* a._imaginary)-(a._valid* b._imaginary))/(b._valid * b._valid + b._imaginary * b._imaginary));
        }

        public static CustomComplex operator *(CustomComplex a, CustomComplex b)
        {
            return new CustomComplex(((a._valid * b._valid)-(a._imaginary * b._imaginary)), ((b._valid * a._imaginary) + (a._valid * b._imaginary)));
        }
    }
}
