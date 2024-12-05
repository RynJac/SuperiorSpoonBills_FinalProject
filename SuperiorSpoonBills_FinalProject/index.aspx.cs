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
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SuperiorSpoonBills_FinalProject
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cmdSolveProblem479_Click(object sender, EventArgs e)
        {
            sharpenn.Solution solution = new sharpenn.Solution();
            int Problem479Solution;
            Problem479Solution = solution.LargestPalindrome(2);
            lblSolution479.Text = Problem479Solution.ToString();
        }

        protected void cmdViewProblem_Click(object sender, EventArgs e)
        {
            if (ddlProblemChoices.SelectedIndex == 0)
            {
                Problem479Description.Visible = true;
                cmdSolveProblem479.Visible = true;
                Problem4Description.Visible = false;
                cmdsolveproblem4.Visible = false;
                Problem233Description.Visible = false;
                cmdSolveProblem233.Visible = false;
                lblSolution4.Text = "";
                lblSolution233.Text = "";
            }
            else if (ddlProblemChoices.SelectedIndex == 1)
            {
                Problem4Description.Visible = true;
                cmdsolveproblem4.Visible = true;
                Problem479Description.Visible = false;
                cmdSolveProblem479.Visible = false;
                Problem233Description.Visible = false;
                cmdSolveProblem233.Visible = false;
                lblSolution479.Text = "";
                lblSolution233.Text = "";
            }
            else if (ddlProblemChoices.SelectedIndex == 3)
            {
                Problem233Description.Visible = true;
                cmdSolveProblem233.Visible = true;
                Problem479Description.Visible = false;
                cmdSolveProblem479.Visible = false;
                Problem4Description.Visible = false;
                cmdsolveproblem4.Visible = false;
                lblSolution479.Text = "";
                lblSolution4.Text = "";
            }

        }

        protected void cmdsolveproblem4_Click(object sender, EventArgs e)
        {
            shinkecj shinkecj = new shinkecj();
            double Problem4Solution;
            int[] nums1 = { 1, 3 };
            int[] nums2 = { 2 };
            Problem4Solution = shinkecj.FindMedianSortedArrays(nums1, nums2);
            lblSolution4.Text = Problem4Solution.ToString();
        }

        protected void cmdSolveProblem233_Click(object sender, EventArgs e)
        {
            bellzj bellzj = new bellzj();
            int Problem233Solution;
            Problem233Solution = bellzj.CountDigitOne(13);
            lblSolution233.Text = Problem233Solution.ToString();
        }


    }
}