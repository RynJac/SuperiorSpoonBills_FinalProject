using SuperiorSpoonBills_FinalProject;

/*Name: Ryan Jacob
* email: Jacobry@mail.uc.edu
* Assignment Number: Final Project
* Due Date: 12 / 10 / 24
* Course #/Section: IS 3050-001
* Semester / Year: Fall 2024
* Brief Description of the assignment: Collaborate using GitHub on a site that solves hard problems from LeetCode and allows a user to select a 
* desired problem and see the description, a test case, and the solution by invoking the code that solves the problem.

* Brief Description of what this module does: This module solves LeetCode Problem 65.
* Citations: https://leetcode.com/problems/valid-number/description/
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperiorSpoonBills_FinalProject
{
    public class Jacobry
    {
        /// <summary>
        /// The Solution class contains the logic for determining if a string represents a valid number.
        /// </summary>
        public class Solution
        {
            /// <summary>
            /// Determines if the given string is a valid numerical representation.
            /// A valid number includes integers, decimals, and scientific notations like '1e10'.
            /// </summary>
            /// <param name="s">The input string to validate.</param>
            /// <returns>
            /// Returns <c>true</c> if the string is a valid number; otherwise, returns <c>false</c>.
            /// </returns>
            public bool IsNumber(string s)
            {
                if (string.IsNullOrWhiteSpace(s)) return false;
                //Test
                s = s.Trim(); // Remove leading and trailing whitespaces
                bool numSeen = false; // If a number is seen
                bool dotSeen = false; // If a dot is seen
                bool eSeen = false;   // If an 'e' or 'E' is seen
                bool numAfterE = true; // To ensure there's a number after 'e' or 'E'

                for (int i = 0; i < s.Length; i++)
                {
                    char c = s[i];

                    if (char.IsDigit(c))
                    {
                        numSeen = true;
                        numAfterE = true;
                    }
                    else if (c == '.')
                    {
                        if (dotSeen || eSeen) return false;
                        dotSeen = true;
                    }
                    else if (c == 'e' || c == 'E')
                    {
                        if (eSeen || !numSeen) return false;
                        eSeen = true;
                        numAfterE = false;
                    }
                    else if (c == '+' || c == '-')
                    {
                        // A '+' or '-' is valid only at the start or after an 'e'
                        if (i != 0 && s[i - 1] != 'e' && s[i - 1] != 'E') return false;
                    }
                    else
                    {
                        // Any other character is invalid
                        return false;
                    }
                }

                return numSeen && numAfterE;
            }
        }
    }
}