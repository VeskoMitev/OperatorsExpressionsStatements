namespace OperatorsExpressionsStatements
{
    using System;
    class DivideBy_7_and_5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer number:");
            int inputNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Divide by 7 and 5: {0}", (inputNumber%7 == 0 && inputNumber%5 == 0));
        }
    }
}
