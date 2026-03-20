using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5.Variant00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1.Number number = new Task1.Number(3);
            Task1.Number number1 = new Task1.Number(-4);
            Task1.Number number2 = new Task1.Number(0);
            Console.WriteLine(number.Sign);
            Console.WriteLine(number1.Abs);
            Console.WriteLine(number2.Real);
            number.Sum(number2);
            Console.WriteLine(number.Real);
            number1.Neg();

            Console.WriteLine(number1.Real);
            number1.Div(number);
            Console.WriteLine(number1.Real);
        }
        
    }
}
