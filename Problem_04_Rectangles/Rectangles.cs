namespace OperatorsExpressionsStatements
{
    using System;
    class Rectangles
    {
        /*
         *  Problem 4.	Rectangles

         * Write an expression that calculates rectangle’s perimeter and area by given width and height.
         */
        static void Main(string[] args)
        {
            Console.Write("Rectangle width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Rectangle heigh: ");
            double heigh = Double.Parse(Console.ReadLine());

            Console.WriteLine("Perimeter: {0}",(2*width)+(2*heigh));
            Console.WriteLine("Area: {0} ",width* heigh );

        }
    }
}
