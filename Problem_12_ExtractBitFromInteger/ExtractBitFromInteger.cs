namespace OperatorsExpressionsStatements
{
    using System;

    /* Problem 12.	Extract Bit from Integer

     * Write an expression that extracts from given integer n the value of given bit at index p
     */ 

    class ExtractBitFromInteger
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            int inputNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Enter bit position:");
            int bitPosition  = Int32.Parse(Console.ReadLine());

            int result = ((inputNumber & (1 << bitPosition)) != 0) ? 1 : 0;

            Console.WriteLine(Convert.ToString(inputNumber, 2).PadLeft(16, '0'));
            Console.WriteLine("{0}", result.ToString().PadLeft(16-bitPosition,' '));
        }
    }
}
