using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_07_PointInACircle
{
    /*
     * Problem 7.	Point in a Circle

     * Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). 
     */ 

    class PointInACircle
    {
        static void Main(string[] args)
        {
            Console.Write("Enter X:");
            double coorX = Double.Parse(Console.ReadLine());

            Console.Write("Enter Y:");
            double coorY = Double.Parse(Console.ReadLine());
            bool result = false;
            double hip = Math.Sqrt((coorX*coorX) + (coorY*coorY));

            result = (hip <= 2);
           
           
            
            Console.WriteLine(result );
        }
    }
}
