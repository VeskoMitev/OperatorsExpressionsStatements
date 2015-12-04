namespace OperatorsExpressionsStatements
{
    using System;
    class OperatorsExpressionsStatements
    {
        /*
         * Problem 15.	* Bits Exchange

         * Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer
         */

        static int ExchangeBit(int number, int startPosition,int exchangePosition, int len)
        {
            int result = number;
      
            for (int i = 0; i <  len; i++)
            {
                bool mask = (number & (1 << (i+startPosition))) != 0U;
                if (mask)
                {
                    //string tmpMask = Convert.ToString(((1 << exchangePosition  + i)), 2);
                    result |= ((1 << exchangePosition + i));
                }
                else
                {
                   // string tmpMask = Convert.ToString(~((1 << exchangePosition  + i)), 2);
                    result &= ~((1 << exchangePosition + i));
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            uint inputNumber = uint.Parse(Console.ReadLine());
            int tmpVal ,result ;
            tmpVal = ExchangeBit((int)inputNumber, 3, 24, 3) ^ ExchangeBit((int)inputNumber , 24, 3, 3);
            result = ((tmpVal ^ (int)inputNumber))  ;
            Console.WriteLine("{2,-13} | {0,32} | {1,10}", Convert.ToString(inputNumber, 2).PadLeft(32, '0'), inputNumber,"Input number");
            Console.WriteLine("{2,-13} | {0,32} | {1,10}", Convert.ToString(result, 2).PadLeft(32, '0'), (uint)result, "Result");
        }
        
    }
}
