using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11_BitwiseExtractBit_3
{

    /*
     * Problem 11.	Bitwise: Extract Bit #3

     * Using bitwise operators, write an expression for finding the value of the bit #3 
     * of a given unsigned integer. The bits are counted from right to left, 
     * starting from bit #0. The result of the expression should be either 1 or 0
     */ 

    class BitwiseExtractBit_3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            int inputNumber = Int32.Parse(Console.ReadLine());

            int result = ((inputNumber & (1 << 3)) !=0)?1:0;
            Console.WriteLine(Convert.ToString(inputNumber,2).PadLeft(16,'0'));
            Console.WriteLine("{0,13}",result);
        }
    }
}
