

namespace OperatorsExpressionsStatements
{
    using System;

    /*
     * Problem 9.	Trapezoids

     * Write an expression that calculates trapezoid's area by given sides a and b and height h. 
     * 
     */
    class Trapezoids
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side a:");
            double sideA = Double.Parse(Console.ReadLine());
            Console.Write("Enter side b:");
            double sideB = Double.Parse(Console.ReadLine());
            Console.Write("Enter height h:");
            double heightH = Double.Parse(Console.ReadLine());

            double trapezeArea = ((sideA + sideB)*heightH)/2;

            Console.WriteLine("Trapezoid area: {0}",trapezeArea);


        }
    }
}
