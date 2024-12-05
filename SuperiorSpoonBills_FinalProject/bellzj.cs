/*Name: Zach Bell
*email: Bellzj@mail.uc.edu
*Assignment Number: IS3050 Final Project
*Due Date: 12/10/2024
*Course #/Section: IS-3050-001
* Semester / Year: Fall 2024
*Brief Description of the assignment: Create an asp.net site that solves leetcode problems
*Brief Description of what this module does: Using our skills from the semester to complete our final
*Citations: Leetcode Problem 233 - https://leetcode.com/problems/number-of-digit-one/description/
*- Google Gemini AI - https://gemini.google.com/app/3bc0a3cbe1997a7c
*Anything else that's relevant:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperiorSpoonBills_FinalProject
{
    /// <summary>
    /// Class that contains a method to solve Leetcode problem 233
    /// </summary>
    public class bellzj
    {
        /// <summary>
        /// Given an integer n, count the total number of digit 1 appearing in all non-negative integers less than or equal to n
        /// </summary>
        /// <param name="n"> An integer </param>
        /// <returns></returns>
        public int CountDigitOne(int n)
        {
            int count = 0;
            long i = 1; // Using long for accurate calculations, especially for large numbers

            while (n / i > 0)
            {
                int digit = (int)(n / i % 10);
                count += (int)(n / (i * 10)) * (int)i; // Explicit casting to int
                if (digit == 1)
                {
                    count += (int)(n % i + 1); // Explicit casting to int
                }
                else if (digit > 1)
                {
                    count += (int)i; // Explicit casting to int
                }
                i *= 10;
            }
            return count;
        }
    }

}