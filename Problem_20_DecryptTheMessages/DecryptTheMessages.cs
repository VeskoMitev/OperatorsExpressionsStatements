namespace OperatorsExpressionsStatements
{
    using System;
    using System.Collections.Generic;
    class DecryptTheMessages
    {
        static void Main(string[] args)
        {
            string inputString = "";
            string ins = "";
            char[] codeSymbol = new[] { '+', '%', '&', '#', '$' };
            char[] decodeSymbol = new[] { ' ', ',', '.', '?', '!' };
            List<string> decodeMessage = new List<string>();
            do
            {
               inputString =  Console.ReadLine();
            } while (inputString != "START" && inputString != "start");
            inputString = Console.ReadLine();
            while (inputString!="END" && inputString !="end")
            {
                
            
                if (string.IsNullOrWhiteSpace(inputString))
                {
                    inputString = Console.ReadLine();
                    continue;
                }

                var massage = inputString.ToCharArray();
                for (int i = 0; i < massage.Length ; i++)
                {
                    char currentChar = massage[i];

                    int inexOfSecialSymbol = Array.IndexOf(codeSymbol, currentChar);
                    if (inexOfSecialSymbol != -1)
                    {
                        currentChar = decodeSymbol[inexOfSecialSymbol];
                    }

                    if ((currentChar >= 'A' && currentChar <= 'M') || (currentChar >= 'a' && currentChar <= 'm'))
                    {
                        currentChar += (char)13;
                    }
                    else if ((currentChar >= 'N' && currentChar <= 'Z') || (currentChar >= 'n' && currentChar <= 'z'))
                    {
                        currentChar -= (char)13;
                    }
                    massage[i] = currentChar;
                    
                }

                Array.Reverse(massage);
           
                decodeMessage.Add(new string(massage));
                inputString = Console.ReadLine();
            }

            if (decodeMessage.Count>0)
            {
               Console.WriteLine("Total number of messages: {0}",decodeMessage.Count);
                foreach (string massage in decodeMessage )
                {
                  Console.WriteLine(massage);  
                }
                
            }
            else
            {
                Console.WriteLine("No message received.");
            }
        }
    }
}
