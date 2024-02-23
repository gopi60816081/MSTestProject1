using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingOfTwoNumber
{
    public class Numbers
    {
        public double number1;
        public double number2;
        public Numbers(double num1,double num2)
        {
            number1 = num1;
            number2 = num2;
        }



            public static double Add(double number1, double number2)
            {
                return (number1 + number2);
            }

            public static double Subtract(double number1, double number2)
            {
                return (number1 - number2);
            }

            public static double Multiply(double number1, double number2)
            {
                return (number1 * number2);
            }

            public static double Divide(double number1, double number2)
            {
                return (number1 / number2);
            }
        

    }
}
