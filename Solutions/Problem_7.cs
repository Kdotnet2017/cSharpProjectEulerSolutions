using System;
namespace cSharpProjectEulerSolutions
{
    public partial class ProjectEuler
    {
        /* *************************************10001st prime**************************************** */
        /*By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
            What is the 10 001st prime number?*/
        /**************************************** Solution ***************************************** */
        /*Solution 1 : loop through integer numbers to find prime numbers */
        /*Solution 2 :  https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes */
        public void p7()
        {
            Console.WriteLine("ProjectEuler Problem #7:");
            /* solution 1 : easy solution */
            int count=0;
            int number=1;
            while(count<10001){
                number++;
                if(isPrime(number)) // call isPrime(n) to find out whether n is prime or not?
                {
                    count++;
                }
            }
            Console.WriteLine("Solution One- Answer for the Problem #7 is : {0}",number);
            
            /* solution 2 : Sieve of Eratosthenes */
            int n = 10000000;
            bool[] primeNumbers = new bool[n];
            for (int i = 2; i < n; i++)
            {
                primeNumbers[i] = true;
            }
            for (int i = 2; i < n; i++)
            {
                if (primeNumbers[i])
                {
                    for (int j = 2; (i * j) < n; j++)
                    {
                        primeNumbers[i * j] = false; // all i * j are not prime. just i is prime.
                    }
                }
            }
            int index =1;
             count=0;
            while(count<10001)
            {
                index++;
                if(primeNumbers[index]){count++;}
                
            }
            Console.WriteLine("Solution Two- Answer for the Problem #7 is : {0}",index);

        }

        /* Method isPrime to detrmine whether argument n is prime numebr or not by returning true or false */
        public bool isPrime(int n)
        {
            bool isPrime = true;  //the flag for checking  prime factor
            double len=Math.Sqrt(n);
            for (int i = 2; i <= len; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }
}