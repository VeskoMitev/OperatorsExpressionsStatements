namespace OperatorsExpressionsStatements
{
    using System;
    class BitsAtCrossroads
    {
        
        static int CalcBoard(int[,] board, ref long[] result)
        {
            int countOfCross = 0;

            for (int i = 0; i < board.GetLength(0); i++)
            {
                long rowResult = 0;
                for (int j = board.GetLength(1) - 1; j >= 0; j--)
                {
                    if (board[i, j]>0)
                    {
                        rowResult +=(long)Math.Pow(2d, j);
                    }
                    if (board[i, j] > 1)
                    {
                        countOfCross++;
                    }
                    
                }

                result[i] = rowResult;
                
            }
            return countOfCross;
        }
        static void Main(string[] args)
        {
            int nSize = int.Parse(Console.ReadLine());
            int[,] board = new int[nSize ,nSize];
            long[] result = new long[nSize];
            string inputData = Console.ReadLine();
            while (inputData != "end")
            {
                var command = inputData.Split(' ');
                int line = int.Parse(command[0]);
                int bitPossition = int.Parse(command[1]);

                int startPossition1 = Math.Min(line, nSize - bitPossition-1);
                int currentPosition1Line = line - startPossition1;
                int currentPosition1Bit = bitPossition + startPossition1;

                int startPossition2 = Math.Min(line,bitPossition);
                int currentPosition2Line = line - startPossition2;
                int currPosition2Bit =  bitPossition -startPossition2;

                for (int i = 0; i < nSize ; i++)
                {
                    if (currentPosition1Line < nSize && currentPosition1Bit >= 0)
                    {
                        board[currentPosition1Line, currentPosition1Bit] += 1;
                        currentPosition1Bit --;
                        currentPosition1Line ++;
                    }
                    if (currentPosition2Line < nSize && currPosition2Bit < nSize)
                    {
                        board[currentPosition2Line, currPosition2Bit] += 1;
                        currPosition2Bit++;
                        currentPosition2Line++;
                    }
                }
               
                inputData = Console.ReadLine();
            }
            
           int countCross= CalcBoard(board,ref result);
            for (int i = 0; i < nSize; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.WriteLine(countCross);
        }
    }
}
