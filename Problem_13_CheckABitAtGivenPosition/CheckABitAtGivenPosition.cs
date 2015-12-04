namespace OperatorsExpressionsStatements
{
    
    using System;

    /*
     * Problem 13.	Check a Bit at Given Position

     * Write a Boolean expression that returns if the bit at position p 
     * (counting from 0, starting from the right) in given integer number n has value of 1
     */ 

    class CheckABitAtGivenPosition
    {
        static void Main()
        {
            Console.Write("Enter number:");
            int inputNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Enter bit position:");
            int bitPosition = Int32.Parse(Console.ReadLine());

            bool result = (inputNumber & (1 << bitPosition)) != 0;

            Console.WriteLine(result);
        }
    }
}
