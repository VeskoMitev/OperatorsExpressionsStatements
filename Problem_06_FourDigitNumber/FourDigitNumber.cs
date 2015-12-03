namespace OperatorsExpressionsStatements
{
    using System;
    class FourDigitNumber
    {
        /*
         * Problem 6.	Four-Digit Number

         * Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
            •	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
            •	Prints on the console the number in reversed order: dcba (in our example 1102).
            •	Puts the last digit in the first position: dabc (in our example 1201).
            •	Exchanges the second and the third digits: acbd (in our example 2101).
         */ 
        static void Main(string[] args)
        {
            string  inputNumber = Console.ReadLine();
            int sum = 0;
            int tmpNum =Convert.ToInt32(inputNumber) ;

            string reverseString = "";

            for (int i = 0; i < inputNumber.ToString().Length ; i++)
            {
                sum += tmpNum%10;
                reverseString +=(tmpNum%10);
                tmpNum /= 10;
            }
            string exchangeDigitString = inputNumber[0].ToString() + inputNumber[2] + inputNumber[1] + inputNumber[3];
            string lastDigitFirstPosition =inputNumber.Substring(inputNumber.Length-1,1)+ inputNumber.Substring(0, inputNumber.Length -1);

            Console.WriteLine("{0,-6} | {1,4} | {2,6} | {3,6} | {4,6}",inputNumber,sum,reverseString ,lastDigitFirstPosition,exchangeDigitString);
        }
    }
}
