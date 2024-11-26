/*
 *Name: Nathan Sharpe
* email: sharpenn@mail.uc.edu
* Assignment Number: Final Project
* Due Date: 12/10/24
* Course #/Section: IS 3050-001
* Semester/Year: Fall 2024
* Brief Description of the assignment: Collaborate using GitHub on a site that solves hard problems from LeetCode and allows a user to select a 
* desired problem and see the description, a test case, and the solution by invoking the code that solves the problem.

* Brief Description of what this module does: Introduces us to collaborating with GitHub on ASP.NET web pages.
* Citations: https://leetcode.com/problems/largest-palindrome-product/, gemini.google.com (to create the problem solution only)
* Anything else that's relevant:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperiorSpoonBills_FinalProject
{
    public class sharpenn
    {
        /// <summary>
        /// This class solves problem 479 on LeetCode "Largest Palindrome Product"
        /// </summary>
        public class Solution
        {
            /// <summary>
            /// Input an integer n to find its largest palindrome product
            /// </summary>
            /// <param name="n">The value to be evaluated for its largest palindrome product</param>
            /// <returns>The largest palindrome product of the inputted n (mod 1337 to avoid massive outputs)</returns>
            public int LargestPalindrome(int n)
            {
                int upperBound = (int)Math.Pow(10, n) - 1;
                int lowerBound = (int)Math.Pow(10, n - 1);
                int maxPalindrome = 0;

                for (int i = upperBound; i >= lowerBound; i--)
                {
                    for (int j = i; j >= lowerBound; j--)
                    {
                        int product = i * j;
                        if (product < maxPalindrome)
                        {
                            break;
                        }

                        if (IsPalindrome(product))
                        {
                            maxPalindrome = Math.Max(maxPalindrome, product);
                        }
                    }
                }

                return maxPalindrome % 1337;
            }

            /// <summary>
            /// Evaluates a number to see if it is a palindrome
            /// </summary>
            /// <param name="num">The number to be evaluated</param>
            /// <returns>True if palindrome, false if not</returns>
            private bool IsPalindrome(int num)
            {
                string numStr = num.ToString();
                int left = 0, right = numStr.Length - 1;

                while (left < right)
                {
                    if (numStr[left] != numStr[right])
                    {
                        return false;
                    }
                    left++;
                    right--;
                }

                return true;
            }
        }
    }
}