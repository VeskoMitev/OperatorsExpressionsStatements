namespace OperatorsExpressionsStatements
{
    using System;
    class KingOfThieves
    {
        static void Main(string[] args)
        {
            int nSize = int.Parse(Console.ReadLine());
            char aSymbol =(char) Console.Read();
            int center =(int) Math.Floor(nSize/2d);
            int counter = 0;
            for (int i = 0; i < nSize; i++)
            {
               

                for (int j = 0; j < nSize; j++)
                {
                 
                    
                    if (j>=center-counter && j <= center+counter)
                    {
                       Console.Write(aSymbol); 
                    }
                    else
                    {
                       Console.Write("-"); 
                    }
                    
                }
                if (i < center) counter++;
                else counter -- ;
                Console.WriteLine();
            }
        }
    }
}
