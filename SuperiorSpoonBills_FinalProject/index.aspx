<!--
Name: Nathan Sharpe
email: sharpenn@mail.uc.edu
Assignment Number: Final Project
Due Date: 12/10/24
Course #/Section: IS 3050-001
Semester/Year: Fall 2024
Brief Description of the assignment: Collaborate using GitHub on a site that solves hard problems from LeetCode and allows a user to select a 
desired problem and see the description, a test case, and the solution by invoking the code that solves the problem.

Brief Description of what this module does: Introduces us to collaborating with GitHub on ASP.NET web pages.
Citations: https://leetcode.com/problems/largest-palindrome-product/, gemini.google.com (to create the problem solution only)
Anything else that's relevant:
    -->

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="SuperiorSpoonBills_FinalProject.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Superior Spoonbills Final Project</title>
</head>
<body>
    <form id="MainPage" runat="server">
            <h1>Welcome to the Superior Spoonbills Final Project</h1>
            <p>
                Do you struggle with the hard problems on LeetCode? Want to see some example problems and solutions to help you out? Simply
                select a problem from the list below and stop stressing!
            </p>
        <asp:DropDownList ID="ddlProblemChoices" runat="server">
            <asp:ListItem>Problem 479: Largest Palindome Product</asp:ListItem>
            <asp:ListItem>Cam&#39;s Problem</asp:ListItem>
            <asp:ListItem>Ryan&#39;s Problem</asp:ListItem>
            <asp:ListItem>Zack&#39;s Problem</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="cmdViewProblem" runat="server" Text="View Problem" OnClick="cmdViewProblem_Click" />
        <p id="Problem479Description" runat="server" visible="false" >
479. Largest Palindrome Product
Given an integer n, return the largest palindromic integer that can be represented as the product of two n-digits integers. Since the answer can be very large, return it modulo 1337.
<br />
Example 1:
<br />
Input: n = 2
<br />
Output: 987
<br />
Explanation: 99 x 91 = 9009, 9009 % 1337 = 987
        </p>    

        <asp:Button ID="cmdSolveProblem479" runat="server" Text="Solve Test Case" OnClick="cmdSolveProblem479_Click" visible="false"/>
            <asp:Label ID="lblSolution479" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
