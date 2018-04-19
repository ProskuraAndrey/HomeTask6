using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class FractionalMathematical
    {
        private int _zn;
        private int _ch;
        public int Chiclitel
        {
            get { return _ch; }
            set { _ch = value; }
        }
        public int Znamenatel
        {
            get { return _zn; }
            set
            {
                if (value == 0) throw new DivideByZeroException("Delit nelzya");
                else _zn = value;
            }
        }

        public FractionalMathematical(int ch = 0, int zn = 1)
        {
            Chiclitel = ch;
            Znamenatel = zn;
        }


        public static FractionalMathematical operator /(FractionalMathematical a, FractionalMathematical b)
        {
            return new FractionalMathematical(a._ch * b._zn , a._zn * b._ch);
        }

        public static FractionalMathematical operator *(FractionalMathematical a, FractionalMathematical b)
        {
            return new FractionalMathematical(a._ch * b._ch, a._zn * b._zn);
        }
    }
}
