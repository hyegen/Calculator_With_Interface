using System;

namespace Calculator_With_Interface
{
    class Program
    {
        public interface ITransaction
        {
            void addition(int num1, int num2);
            void multiplication(int num1, int num2);
            void subtraction(int num1, int num2);
            void division(double num1, double num2);

        }
        public class Calculation : ITransaction
        {
            public void addition(int num1, int num2)
            {
                Console.WriteLine("Addition: " + num1 + "+" + num2 + "=" + (num1 + num2));
            }

            public void division(double num1, double num2)
            {
                Console.WriteLine("Division: " + num1 + "/" + num2 + "=" + (num1 / num2));
            }


            public void multiplication(int num1, int num2)
            {
                Console.WriteLine("Multiplication: " + num1 + "*" + num2 + "=" + num1 * num2);
            }

            public void subtraction(int num1, int num2)
            {
                if (num2 < num1)
                {
                    Console.WriteLine("Subtraction: " + num1 + "-" + num2 + "=" + (num1 - num2));

                }
                else Console.WriteLine("Num1 cannot be less than Num2");
            }
        }
        static void Main(string[] args)
        {
            Calculation calc = new Calculation();
            calc.addition(6, 4);
            calc.multiplication(6, 4);
            calc.division(6, 4);
            calc.subtraction(6, 4);
        }
    }
}

