

namespace OperatorsExpressionsStatements
{
    using System;
    class ThirdDigitIs_7
    {
        /*
         * Problem 5.	Third Digit is 7?

         * Write an expression that checks for given integer if its third digit from right-to-left is 7
         */ 

        static void Main(string[] args)
        {
            Console.Write("Enter integer number:");
            int inputNumber = Int32.Parse(Console.ReadLine());

            bool result = false;
            for (int i = 0; i < 2; i++)
            {
                inputNumber /= 10;
            }
            inputNumber %= 10;
            if (inputNumber == 7) result = true;
            Console.WriteLine(result);
        }
    }
}
