using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExpressionsStatements
{
    class BookProblem
    {
        static void Main(string[] args)
        {
            uint countOfPages = uint.Parse(Console.ReadLine());
            byte campingDays = byte.Parse(Console.ReadLine());
            byte readsPagesOfDay = byte.Parse(Console.ReadLine());
            const byte daysOfMonth = 30;
            int readPagesOfMonth =(daysOfMonth  - campingDays) * readsPagesOfDay;
            if (readPagesOfMonth==0)
            {
                Console.WriteLine("never");
                return;
            }
            double needMonthCount = Math.Ceiling(countOfPages/(double)readPagesOfMonth);


            Console.WriteLine("{0} years {1} months",(int)needMonthCount/12,(int)needMonthCount%12);


        }
    }
}
