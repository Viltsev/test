using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class FuncMath
    {
        int calls;

        public int plus(int a, int b)
        {
            calls++;
            return a + b;
        }

        public int multiplication(int a, int b)
        {
            calls++;
            return a * b;
        }

        public int division(int a, int b)
        {
            calls++;
            if (b == 0)
            {
                throw new ArithmeticException("Division by zero!");
            }
            return a / b;
        }

        public long factorial(int number)
        {
            calls++;

            if (number < 0) throw new ArgumentOutOfRangeException("Number should be > 0");

            long result = 1;

            if (number > 1)
            {
                for (int i = 1; i <= number; i++)
                {
                    result = result * i;
                }
            }
            return result;
        }




        public int getCalls()
        {
            return calls;
        }


    }
}
