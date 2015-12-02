namespace OperatorsExpressionsStatements
{
    using System;

    class GravitationOnTheMoon
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your weight:");
            double weight = Double.Parse(Console.ReadLine());

            Console.WriteLine("Your weight on the moon: {0} kg",weight * 0.17);
        }
    }
}