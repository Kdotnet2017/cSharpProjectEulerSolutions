using System;
namespace cSharpProjectEulerSolutions
{
    public partial class ProjectEuler
    {
        // The following problem is taken from Project Euler.
       // http://projecteuler.net/problem=3
       /**********************Largest prime factor****************************** */
       // The prime factors of 13195 are 5, 7, 13 and 29.
       //What is the largest prime factor of the number 600851475143 ?
       
        public void p3()
        {
            var n=600851475143;  // n is input from user - ulong type range is 0 to 18,446,744,073,709,551,615
            uint largestPrimeFactor=0;  // uint range is 0 to 4,294,967,295 - holds the answer? output?
            Console.WriteLine("ProjectEuler Problem #3:");

       /********************************Solution******************************* */
       //1-The Key is Prime Factor So what is Prime number & what are Factors?
       //1-1- Factors are numbers that we can multiply together to get another number. For example 3 x 4 =12 also 2 X 6 = 12 are factors of 12.
       //1-2- A Prime number is a positive integer(natural) number that is divisible ONLY by 1 and itself. For example: 2,3,5,7,11,13.17
       //2- So, Prime Factors of 12 are 2 , 3
       //3- Also, the integer factors of a number approximate to the square root of it.
       /* ****************************** Solution **************** */
       // According above descriptions ( 1 to 3), we can use two nested for  loops first loop to find factors then second one to find out whether those factors are prime or not.
            
            for(uint i=2;i<Math.Sqrt(n);i++)
            {
                if(n%i==0)
                {               // we found the factors
                    bool isPrime=true;  //the flag for checking  prime factor
                    for(uint j=2;j<i;j++)   // Prime checking 
                    {
                        if(i%j==0)
                        {
                            isPrime=false;
                            break;   // exit the j for loop
                        }
                    }
                    if(isPrime==true)
                    {
                        largestPrimeFactor=i;
                       // Console.WriteLine(largestPrimeFactor);
                    }
                }

            }
             Console.WriteLine("Answer for the Problem #3 is : {0}", largestPrimeFactor.ToString());
        }
    }
}