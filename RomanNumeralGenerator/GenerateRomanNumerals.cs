using System;
using System.Collections.Generic;

namespace RomanNumeralGenerator
{
    public class GenerateRomanNumerals
    {
        public static Dictionary<char, int> romNum = new Dictionary<char, int>() {
            {'I', 1 },
            {'V', 5 },
            {'X', 10 },
            {'L', 50 },
            {'C', 100 },
            {'D', 500 },
            {'M', 1000 }
        };
        public static string[] validInbetweenValues = { "IV", "IX", "XL", "XC", "CD", "CM" };

        public static int ConvertRomanNumerals(string strRomanNum)
        {
            int total = 0;

            strRomanNum = strRomanNum.ToUpper();

            for (var i = 0; i < strRomanNum.Length; i++)
            {
                bool inBtwValue = false;
                
                if (!romNum.ContainsKey(strRomanNum[i])) throw new ArgumentException("Not a roman numeral!");
                var first = romNum[strRomanNum[i]];

                if (i < strRomanNum.Length - 1 && romNum.ContainsKey(strRomanNum[i + 1]))
                {
                    var second = romNum[strRomanNum[i + 1]];
                    if (first < second
                        && Array.FindIndex(validInbetweenValues, v => v == string.Concat(strRomanNum[i], strRomanNum[i + 1])) > -1)
                    {
                        inBtwValue = true;
                    }
                }
                if (inBtwValue) total -= first;
                else total += first;
            }
            return total;
        }

    }
}
