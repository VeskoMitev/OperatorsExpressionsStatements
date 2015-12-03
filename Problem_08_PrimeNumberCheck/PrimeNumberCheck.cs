namespace Problem_08_PrimeNumberCheck
{
    using System;
   
    /*
     * Problem 8.	Prime Number Check
    
     * Write an expression that checks if given positive integer number n (n ≤ 100)
     * is prime (i.e. it is divisible without remainder only to itself and 1). 
     */ 

    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer number:");
            int inputNumber = Int32.Parse(Console.ReadLine());



            bool result = true;
            for (int i = 2; i < inputNumber - 1; i++)
            {
                if (inputNumber % i == 0)
                {
                    result = false;
                    break;
                }
            }

            Console.WriteLine("The number {1} {0} prime.", result ? "is" : "is not a", inputNumber);
                
           
           

        }
    }
}
