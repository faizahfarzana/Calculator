using System;

namespace Operations.Services
{
    public class CalculatorService : ICalculatorService
    {
        public double Calculate(double Number1, double Number2, string Operator)
        {
            if (Operator == "+")
            {
                return Add(Number1, Number2);
            }
            
            else if (Operator == "-")
            {
                return Subtract(Number1, Number2);
            }

            else if (Operator == "*")
            {
                return Multiply(Number1, Number2);
            }

            else if (Operator == "/")
            {
                return Divide(Number1, Number2);
            }

            else
            {
                throw new InvalidOperationException("Invalid Operator!");
            }
        }

        private double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        private double Subtract(double number1, double number2)
        {
            return number1 - number2;
        }

        private double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        private double Divide(double number1, double number2)
        {
            return number1 / number2;
        }
    }
}
