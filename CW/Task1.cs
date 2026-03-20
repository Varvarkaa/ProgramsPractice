using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5.Variant00
{
    public class Task1
    {
        public  struct Number: INumber
        {
            private double _real;

            public double Real => _real;
            public double Abs => Math.Abs(_real);
            public int Sign
            {
                get
                { 
                    if (_real < 0) return -1;
                    if (_real > 0) return 1;
                    return 0;
                }
            }
            public Number(double real)
            {
                _real = real;
                
            }

            // num1.Sum(num2)
            // Console.WriteLine(num2.Real)
            public void Sum(INumber other)
            {
                _real = _real + other.Real;
            }
            public void Sub(INumber other)
            {
                _real = _real - other.Real;
            }
            public void Mul(INumber other)
            {
                _real = _real * other.Real;
            }
            public void Div(INumber other)
            {
                if (other.Real != 0)
                {
                    _real = _real / other.Real;
                }
            }
            public void Neg()
            {
                _real = -1 * _real;
            }
            
        }

    }
}
