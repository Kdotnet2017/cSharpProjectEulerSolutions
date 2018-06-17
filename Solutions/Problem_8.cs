using System;
using System.IO;

namespace cSharpProjectEulerSolutions
{
    public partial class ProjectEuler
    {
        /********************************************Largest product in a series*************************************** */
        /*       The four adjacent digits in the 1000-digit number that have the greatest product are 9 × 9 × 8 × 9 = 5832.
                Find the thirteen adjacent digits in the 1000-digit number that have the greatest product.
                 What is the value of this product? */
        /**************************************** Solution ***************************************** */
        /* I use a basic solution using one  loop for each 13 adjacent digits and calculate the product value to compare with the previous
        one until finding the greatest one.  */
        public void p8()
        {
            Console.WriteLine("ProjectEuler Problem #8:");
            string numbers = pureNumbers(); //calling pureNumbers()  method.
            int numbersLength = numbers.Length - 12;
            string adjacentDigits=""; // holds thirteen adjacent digits
            string gProduct = ""; // holds the greatest thirteen adjacent digits
            long gProductValue = 0;  //the greatest product value
            for (int i = 0; i < numbersLength; i++)
            {
                adjacentDigits = numbers.Substring(i, 13);
                long temp = productValue(adjacentDigits); //calling productValue to calculate the value of greatest product.
                if (gProductValue < temp)
                {
                    gProduct=adjacentDigits;
                    gProductValue = temp;
                }
            }
            Console.WriteLine("Answer for the Problem #8 is :" + gProductValue.ToString());
            Console.WriteLine("The thirteen adjacent digits in the 1000-digit number is : {0}",gProduct);
        }

        /* calculate the product value  */
        private long productValue(string gProduct)
        {
            if (gProduct.Contains("0"))
            {
                return 0;
            }
            else
            {
                long gProductValue = 1;
                foreach (char c in gProduct)
                {
                    // assume all digits are number no letter or special character in the file.
                    int num = int.Parse(c.ToString());
                    gProductValue *= num;
                }
                return gProductValue;
            }
        }

        /* reading 1000 digit number from the file and clean it up(removing \n new line from the end of each line.) */
        private string pureNumbers()
        {
            string[] numLines;
            numLines = File.ReadAllLines("docs/Problem_8_1000_digit_number.txt");
            string numbers = "";
            foreach (string line in numLines)
            {
                numbers += line;
            }
            return numbers;
        }
    }
}