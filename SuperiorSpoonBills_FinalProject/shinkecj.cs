/*Name: Cam Shinker
*email: shinkecj@mail.uc.edu
*Assignment Number: Final Project
*Due Date: 12/10/2024
*Course #/Section: IS-3050-001
* Semester / Year: Fall 2024
*Brief Description of the assignment: Create an asp.net site that solves leetcode problems

*Brief Description of what this module does: Using our skills from the semester to complete our final
*Citations: Leetcode Problem 4 - https://leetcode.com/problems/median-of-two-sorted-arrays/description/
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
    /// Class that contains a method to solve leetcode problem 4
    /// </summary>
    public class shinkecj
    {
        /// <summary>
        /// Input two sorted arrays and it will find the median of all the numbers
        /// </summary>
        /// <param name="nums1">An array of numbers</param>
        /// <param name="nums2">A second array of numbers</param>
        /// <returns>The median of the two arrays</returns>
            public double FindMedianSortedArrays(int[] nums1, int[] nums2)
            {
                int m = nums1.Length;
                int n = nums2.Length;

                // Ensure nums1 is the shorter array
             
                if (m > n)
                {
                    return FindMedianSortedArrays(nums2, nums1);
                }

                int partitionSize = (m + n + 1) / 2;

                int low = 0;
                int high = m;

                while (low <= high)
                {
                    int partitionX = low + (high - low) / 2;
                    int partitionY = partitionSize - partitionX;

                    // Get the elements on either side of the partition
                    int maxLeftX = partitionX == 0 ? int.MinValue : nums1[partitionX - 1];
                    int minRightX = partitionX == m ? int.MaxValue : nums1[partitionX];

                    int maxLeftY = partitionY == 0 ? int.MinValue : nums2[partitionY - 1];
                    int minRightY = partitionY == n ? int.MaxValue : nums2[partitionY];


                    // Check if the partition is correct
                    if (maxLeftX <= minRightY && maxLeftY <= minRightX)
                    {
                        // If the combined array length is even
                        if ((m + n) % 2 == 0)
                        {
                            return (Math.Max(maxLeftX, maxLeftY) + Math.Min(minRightX, minRightY)) / 2.0;
                        }
                        else
                        {
                            return Math.Max(maxLeftX, maxLeftY);

                        }
                    }
                    else if (maxLeftX > minRightY)
                    {
                        high = partitionX - 1;
                    }
                    else
                    {
                        low = partitionX + 1;

                    }
                }

                return 0.0; // This should never happen
            }
        }

    }
