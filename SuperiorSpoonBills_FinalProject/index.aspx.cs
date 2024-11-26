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
            }
        }
    }
}