using System;

namespace cSharpProjectEulerSolutions
{
    public partial class ProjectEuler
    {
        // The following problem is taken from Project Euler.
        // http://projecteuler.net/problem=5
        /**********************************Smallest multiple******************************* */
        /*
        2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
         */
         /***********************************Solution *********************************** */
         /* Two loops will solve the problem. The inside 'FOR loop' is to make sure that is divisible by all of the numbers (i) from 2 to 20
            We know all numbers are divisible by 1 so our i starts from 2. The outside 'WHILE loop' is for increasing by one smallestNumber until we find out the answer.
          */
        public void p5()
        {
            uint smallestNumber = 20;
            Console.WriteLine("ProjectEuler Problem #5:");
            do
            {
                for (int i = 2; i <= 20; i++)
                {
                    if (smallestNumber % i != 0)
                    {
                        smallestNumber++;
                        i = 2;
                    }
                }
                break;
            } while (true);
            Console.WriteLine("Answer for the Problem #5 is : {0}",smallestNumber);

        }
    }
}