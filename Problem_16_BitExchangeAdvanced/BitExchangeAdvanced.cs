namespace OperatorsExpressionsStatements
{
    /*
     * Problem 16.	** Bit Exchange (Advanced)

     * Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} 
     * of a given 32-bit unsigned integer. The first and the second sequence of bits may not overlap. 
     */ 

    using System;
    class BitExchangeAdvanced
    {
        static int ExchangeBit(int number, int startPosition, int exchangePosition, int len)
        {
            int result = number;

            for (int i = 0; i < len; i++)
            {
                bool mask = (number & (1 << (i + startPosition))) != 0U;
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
            Console.Write("Enter unsigned integer number:");
            uint inputNumber = uint.Parse(Console.ReadLine());

            Console.Write("Enter integer number for bit position 1:");
            int bitpossition1 = int.Parse(Console.ReadLine());

            Console.Write("Enter integer number for bit position 2:");
            int bitPossition2 = int.Parse(Console.ReadLine());

            Console.Write("Enter integer number for lenght:");
            int bitLenght = int.Parse(Console.ReadLine());

            if (Math.Max(bitpossition1, bitPossition2) + bitLenght > 32)
            {
                Console.WriteLine("Out of range");
                return;
            }
            else if (Math.Min(bitpossition1, bitPossition2) + bitLenght > Math.Max(bitpossition1,bitPossition2))
            {
                Console.WriteLine("Overlapping");
                return;
            }
           
            int tmpVal, result;
            tmpVal = ExchangeBit((int)inputNumber, bitpossition1 , bitPossition2 , bitLenght ) ^ 
                ExchangeBit((int)inputNumber,bitPossition2 , bitpossition1, bitLenght );
            result = ((tmpVal ^ (int)inputNumber));
            Console.WriteLine("{2,-13} | {0,32} | {1,10}", Convert.ToString(inputNumber, 2).PadLeft(32, '0'), inputNumber, "Input number");
            Console.WriteLine("{2,-13} | {0,32} | {1,10}", Convert.ToString(result, 2).PadLeft(32, '0'), (uint)result, "Result");
        }
    }
}
