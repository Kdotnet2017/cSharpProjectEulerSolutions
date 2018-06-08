using System;
namespace cSharpProjectEulerSolutions
{
    public partial class ProjectEuler
    {
        // The following problem is taken from Project Euler.
        // http://projecteuler.net/problem=6
        /**********************************Sum square difference********************************** */
        /*
            The sum of the squares of the first ten natural numbers is,
            1^2 + 2^2 + ... + 10^2 = 385
            The square of the sum of the first ten natural numbers is,
            (1 + 2 + ... + 10)^2 = 55^2 = 3025
            Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
            Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
         */
         /* ******************************************Solution************************************** */
         /*There is a mathematical formula for each one: 1- The sum of the first n natural numbers equals (n(n+1))/2
            2-Square pyramidal number:  The sum of the first n square numbers equals (n(n+1)(2*n+1))/6
            AND the difference between the sum of the squares of the first n natural numbers and the square of the sum is :
                                                         (n(n+1)(n-1)(3n+2))/12
              */
        public void p6()
        {
             Console.WriteLine("ProjectEuler Problem #6:");
             int n=100;
             int difference=(n*(n+1)*(n-1)*(3*n+2))/12;
             Console.WriteLine("Answer for the Problem #6 is :" + difference.ToString());
        }
    }
}