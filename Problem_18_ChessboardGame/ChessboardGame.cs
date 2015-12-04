using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExpressionsStatements
{
    class ChessboardGame
    {
        static void Main(string[] args)
        {
            int nSize = Int32.Parse(Console.ReadLine());
            string inputString = Console.ReadLine();
            inputString = inputString.PadRight((nSize * nSize), '_');
            var tmpString = inputString.Select(x => char.IsLetterOrDigit(x) ? x : 0).ToArray();
            int scoreBlackTeam = 0;
            int scoreWhiteTeam = 0;
            for (int i = 0; i < nSize * nSize; i++)
            {
                if (i%2==0)
                {
                    if (char.IsLower((char) tmpString[i])||char.IsDigit((char)tmpString[i]))
                    {
                        scoreBlackTeam += tmpString[i];
                    }
                    else
                    {
                        scoreWhiteTeam += tmpString[i];
                        
                    }
                }
                else
                {
                    if (!(char.IsLower((char)tmpString[i]) || char.IsDigit((char)tmpString[i])) )
                    {
                        scoreBlackTeam += tmpString[i];
                    }
                    else
                    {
                        scoreWhiteTeam += tmpString[i];
                        
                    } 
                }

                
            }
            if (scoreBlackTeam == scoreWhiteTeam)
            {
                Console.WriteLine("Equal result: {0}", scoreWhiteTeam);
            }
            else
            {
                Console.WriteLine("The winner is: {0} team", (scoreBlackTeam > scoreWhiteTeam) ? "black" : "white");
                Console.WriteLine(Math.Abs(scoreWhiteTeam - scoreBlackTeam));
            }
        }
    }
}
