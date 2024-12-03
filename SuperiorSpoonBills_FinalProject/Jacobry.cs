using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperiorSpoonBills_FinalProject
{
    public class Jacobry
    {
        public class Solution
        {
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