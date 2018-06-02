using System;
using System.Diagnostics;

namespace cSharpProjectEulerSolutions
{
    public partial class ProjectEuler
    {
       public ProjectEuler()
       {

       } 
       // The following problem is taken from Project Euler.
       // http://projecteuler.net/problem=1
        /********************************Multiples of 3 and 5 ************************ */
       /*
        If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
        The sum of these multiples is 23.
        Find the sum of all the multiples of 3 or 5 below 1000.
        */

       public void p1()
       {
            Console.WriteLine("ProjectEuler Problem #1:");
           // var exeTime = Stopwatch.StartNew();
            // in Big O notation is O(n)
            //******************************************** */
            // Solution one to solve the problem
            decimal sum = 0;
            decimal n = 1000;
            int d1 = 3;
            int d2 = 5;
            for (int i = d1; i < 1000; i++)
            {
                if (i % d1 == 0 || i % d2 == 0) // if divided by 3 or 5 then calculate sum
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Solution One- Answer for the Problem #1 is :" + sum.ToString());
           //  exeTime.Stop();
          //   Console.WriteLine("Execution Time : " + exeTime.ElapsedMilliseconds);

           //  Solution two  based on formula m=floor(n/d) and   for i=1 until m then Zigma(i*d) = d*((m*(m+1))/2)
            // O notation is O(1)

            sum=0;
            n=n-1;
            int d1byd2 = d1*d2;
            decimal m1 = Math.Floor(n / d1);
            decimal m2 = Math.Floor(n / d2);
            decimal m3 = Math.Floor(n / d1byd2);
            // sum of multiples of 3 and 5 is Zigma(i*3)+Zigma(i*5) - Zigma(i*15)
            sum = ((d1 * ((m1 * (m1 + 1)) / 2)) + (d2 * ((m2 * (m2 + 1)) / 2))) - (d1byd2 * ((m3 * (m3 + 1)) / 2));
            Console.WriteLine("Solution Two- Answer for the Problem #1 is :" + sum.ToString());
       }
    }
}