using System;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Subtract(int first, int second)
        {
            return first - second;
        }

        public int Multiply(int first, int second)
        {
            return first * second;
        }

        public (int result, int remainder) Divide(int first, int second)
        {
            if (second == 0)
            {
                throw new DivideByZeroException();
            }

            int result = first / second;
            int remainder = first % second;
            return (result, remainder);
        }
    }
}
