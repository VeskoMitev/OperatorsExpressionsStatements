


namespace OperatorsExpressionsStatements
{
    using System;

    /*
     * Problem 14.	Modify a Bit at Given Position

     * We are given an integer number n, a bit value v (v=0 or 1)
     * and a position p. Write a sequence of operators (a few lines of C# code)
     * that modifies n to hold the value v at the position p from the binary 
     * representation of n while preserving all other bits in n. 
     */ 

    class ModifyABitAtGivenPosition
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer number:");
            int inputNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter integer number of bit position:");
            int bitPosition = int.Parse(Console.ReadLine());

            Console.Write("Enter bit value (0 or 1):");
            int bitValue = int.Parse(Console.ReadLine());
            int result = inputNumber;
            if (bitValue == 0)
            {
                result = inputNumber & ~(1 << bitPosition);
            }
            else if (bitValue == 1)
            {
                result = inputNumber | (1 << bitPosition);
            }
            else
            {
                return;
            }
            Console.WriteLine("{2,-13} | {0,32} | {1,10}", Convert.ToString(inputNumber, 2).PadLeft(32, '0'), inputNumber, "Input number");
            Console.WriteLine("{2,-13} | {0,32} | {1,10}", Convert.ToString(result, 2).PadLeft(32, '0'), (uint)result, "Result");
        }
    }
}
