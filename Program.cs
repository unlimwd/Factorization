using System;
using System.Collections.Generic;

namespace myProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = 2*3*7*5*13;
            Console.WriteLine("The given number is {0}", value);
            List<int> PrimeDevisorsList = new List<int>();
            var currentPrimeDevisor = 2;
            
            do
            {
                while (value % currentPrimeDevisor == 0)    //while (value may be devised by currentPrimeDevisor)
                {
                    value /= currentPrimeDevisor;                    
                    PrimeDevisorsList.Add(currentPrimeDevisor);
                }

                currentPrimeDevisor = nextPrimeDevisor(currentPrimeDevisor);
                if (currentPrimeDevisor == 0) break;
            }
            while (currentPrimeDevisor <= value);

            Console.WriteLine("Prime devisors are:");
            PrimeDevisorsList.ForEach(Console.WriteLine);
            Console.ReadLine();
        }

        static int nextPrimeDevisor(int currentPrimeDevisor)
        {
            var nextPrimeDevisor = 0;
            //in the table of prime numbers, next prime number different from current prime number by 2 or by 4
            if (IsPrimeNumber(currentPrimeDevisor + 2)) nextPrimeDevisor = currentPrimeDevisor + 2;
            else if (IsPrimeNumber(currentPrimeDevisor + 4)) nextPrimeDevisor = currentPrimeDevisor + 4;
            else if (currentPrimeDevisor == 2) nextPrimeDevisor = 3;
            return nextPrimeDevisor;
        }

        static bool IsPrimeNumber(int numberToCheck)
        {

            bool isPrimeNumber = true;

            for (int i = 2; i < numberToCheck; i++)
            {
                if (numberToCheck % i == 0)
                    isPrimeNumber = false;
            }

            return isPrimeNumber;
        }
    }
}
