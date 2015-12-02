namespace OperatorsExpressionsStatements
{
    using System;
    class OddOrEvenIntegers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            int inputNumber = int.Parse(Console.ReadLine());
            
            Console.Write("This number is ");
            if (inputNumber%2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
