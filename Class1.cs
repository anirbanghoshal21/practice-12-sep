using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculation
    {
       
        private double result;

        public double Number
        {
            get;
            set;
        }
        public void Cube()
        {
            Console.Write("Enter the Number : ");
            Number = double.Parse(Console.ReadLine());
            result = Math.Ceiling(Math.Pow(Number, (double)1 / 3));

        }
        public void sqrt()
        {
            double Number = 144;
            Console.WriteLine(Math.Sqrt(Number));
        }
    }
}
