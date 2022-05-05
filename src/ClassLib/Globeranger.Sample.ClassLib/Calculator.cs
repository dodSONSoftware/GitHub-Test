using System;

namespace Globeranger.Sample.ClassLib {

    /// <summary>
    /// Provides basic calculator functionality
    /// </summary>
    public class Calculator : ICalculator {

        // ctor

        private Calculator ( ) { }



        // public methods

        public double Add ( double a, double b ) => a + b;

        public double Subtract ( double a, double b ) => a - b;

        public double Multiply ( double a, double b ) => a * b;

        public double Divide ( double a, double b ) => a / b;

        public double Modulus ( double a, double b ) => a % b;
    }
}
