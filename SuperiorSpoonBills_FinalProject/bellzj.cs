using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperiorSpoonBills_FinalProject
{
    public class bellzj
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
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
