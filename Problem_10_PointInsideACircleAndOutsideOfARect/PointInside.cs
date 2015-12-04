


namespace OperatorsExpressionsStatements
{
    using System;
    /*
     *      Problem 10.	Point Inside a Circle & Outside of a Rectangle

     * Write an expression that checks for given point (x, y) if it is within 
     * the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). 
     * 
     */

    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
    
    class PointInside
    {
        static public double CheckPointInLine(Point point,Point pointA,Point pointB )
        {

            /* Уравнение на правата Аx+By+C=0;
             * 
             * Намираме детерминантата на матрицата
             * 
             * |x   y   1 | 
             * |x1  y1  1 | 
             * |x2  y2  1 | 
             * 
             * (x*y1+y*x2+x1*y2)-(y*x1+x*y2+y1*x2)=
             * = (y1-y2)*x + (x2-x1)*y + x1*y2-x2*y1 =>
             * 
             * => A=(y1-y2) ; B=(x2-x1) ; C=(x1y2-x2y1)
             * 
             * Ako:
             * 1. Ax+Bx+C>0 - Toчката е над правата    pointA(x1,y1) - pointB(x2,y2)
             * 2. Ах+Вх+С=0 - Точката лежи на парвата
             * 3. Ах+Вх+С<0 - Точката е под парвата
             * 
             */ 
            double result = 0D;
            double a = pointA.Y - pointB.Y;
            double b = pointB.X - pointA.X;
            double c = (pointA.X*pointB.Y) - (pointB.X*pointA.Y);

            result = a*point.X + b*point.Y + c;
            return result;
        }

        static public bool PointInsideRect(Point rectStartPoint, Point rectSize, Point point)
        {
            Point linePointA = new Point() { X = rectStartPoint.X , Y = rectStartPoint.Y };
            Point linePointB = new Point() { X = rectStartPoint.X+rectSize.X, Y = rectStartPoint.Y  };
            Point linePointC = new Point() { X = rectStartPoint.X + rectSize.X, Y = rectStartPoint.Y-rectSize.Y };
            Point linePointD = new Point() { X = rectStartPoint.X, Y =  rectStartPoint.Y - rectSize.Y };

            double checkSideAB = CheckPointInLine(point, linePointA, linePointB);
            double checkSideBC = CheckPointInLine(point, linePointC, linePointB);
            double checkSideCD = CheckPointInLine(point, linePointD, linePointC);
            double checkSideDA = CheckPointInLine(point, linePointD, linePointA);

            bool result = (checkSideAB <= 0) && (checkSideCD >= 0) && (checkSideBC >= 0) && (checkSideDA <= 0);
            return result;
        }
        static void Main(string[] args)
        {   
            
            Console.Write("Enter X:");
            double inputX = double.Parse(Console.ReadLine());
            Console.Write("Enter Y:");
            double inputY = double.Parse(Console.ReadLine());

            Point p = new Point(){X = inputX ,Y=inputY};

            bool checkPointInRect = PointInsideRect(new Point() {X = -1, Y = 1}, new Point() {X = 6, Y = 2},p);
            Point circleCenter = new Point() {X = 1, Y = 1};
            double circleRadius = 1.5;

            double distFromCircleCenter =
                Math.Sqrt((p.X - circleCenter.X)*(p.X - circleCenter.X) + (p.Y - circleCenter.Y)*(p.Y - circleCenter.Y));

            bool result = (distFromCircleCenter <= circleRadius) && (!checkPointInRect);
            Console.WriteLine(result);

        }
    }
}
