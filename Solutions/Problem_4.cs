using System;
//using System.Runtime.InteropServices;
namespace cSharpProjectEulerSolutions
{
    public partial class ProjectEuler
    {
         // The following problem is taken from Project Euler.
       // http://projecteuler.net/problem=4
       /*********************Largest palindrome product****************************** */
       /*
        A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is
         9009 = 91 × 99.
        Find the largest palindrome made from the product of two 3-digit numbers.
        */
        public void p4()
        {
            var maxProduct = 0;
            string numbers = "";
             /* ****************************** Solution **************** */
             /* Using two for loops to find the largest product by myltiplying 100 upwards 999. If the product digits are abccba then it's
             one of the palindrome.*/
             /*After executing the method p4(), the best practice is to downward i,j in the for loops */
             /* If it increases i and j upwards the algorithm would be too slow. We should downward i and j for this algorithm. */
            Console.WriteLine("ProjectEuler Problem #4:");
            for (int  i = 999; i > 99; i--)
            {
                for (int j = 999; j > 99; j--)
                {
                    var product = i * j;
                    if (product > 99999)
                    {
                       string strProduct = product.ToString();
                       /*the largest product will be 999*999=998001 - 6 digits if the digits look like abccba then it's a palindrome */
                        if (strProduct[0] == strProduct[5] && strProduct[1] == strProduct[4] && strProduct[2] == strProduct[3])
                        {
                            if (maxProduct < product)
                            {
                                maxProduct = product;
                                numbers = i.ToString() + " * " + j.ToString();
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Answer for the Problem #4 is : {0} that comes from {1}", maxProduct.ToString(), numbers);
        }
    }
}