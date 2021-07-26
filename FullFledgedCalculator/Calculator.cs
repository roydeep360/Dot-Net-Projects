using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullFledgedCalculator
{
    class Calculator
    {
        public double num1 { get; set; }
        public double num2 { get; set; }

        public Calculator() { }

        public Calculator(double num1)
        {
            this.num1 = num1;
        }

        public Calculator(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public void Add()
        {
            Console.WriteLine("Sum of {0} and {1} is {2}", num1, num2, num1 + num2);
        }

        public void Subtract()
        {
            Console.WriteLine("Difference of {0} and {1} is {2}", num1, num2, num1 - num2);
        }

        public void Multiply()
        {
            Console.WriteLine("Multiplication of {0} and {1} is {2}", num1, num2, num1 * num2);
        }

        public void Divide()
        {
            Console.WriteLine("Division of {0} by {1} is {2}", num1, num2, num1 /  num2);
        }

        public void Percentage()
        {
            Console.WriteLine("Percentage of {0} is {1}", num1, (num1/num2)*100+"%");
        }

        public void Power()
        {
            Console.WriteLine("Power of {0} is {1}", num1, Math.Pow(num1,num2));
        }

        public void SquareRoot()
        {
            Console.WriteLine("Square Root of {0} is {1}", num1, Math.Sqrt(num1));
        }

        public void Log()
        {
            Console.WriteLine("The Log of {0} is {1}",num1, Math.Log10(num1));
        }

        public void NaturalLog()
        {
            Console.WriteLine("The Natural Log of {0} is {1}", num1, Math.Log(num1));
        }

        public void Sin()
        {
            Console.WriteLine("The Sin value of {0} is {1}", num1, Math.Sin(num1));
        }

        public void Cos()
        {
            Console.WriteLine("The Cos value of {0} is {1}", num1, Math.Cos(num1));
        }

        public void Tan()
        {
            Console.WriteLine("The Tan value of {0} is {1}", num1, Math.Tan(num1));
        }

    }
}
