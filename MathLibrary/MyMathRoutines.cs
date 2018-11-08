using System;

namespace MyMathRoutines
{
    public class MathConverter
    {
        public static decimal Add(decimal left, decimal right)
        {
            return left + right;
        }
        public static decimal Subtract(decimal left, decimal right)
        {
            return left - right;
        }
        public static decimal Multiply(decimal left, decimal right)
        {
            return left * right;
        }
        public static decimal Divide(decimal left, decimal right)
        {
            return left / right;
        }
        public static double Power(double left, double right)
        {
            return Math.Pow(left, right);
        }
        public static decimal Floor(decimal number)
        {
            return Math.Floor(number);
        }
        public static decimal Ceiling(decimal number)
        {
            return Math.Ceiling(number);
        }
    }
}