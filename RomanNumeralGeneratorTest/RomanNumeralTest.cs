using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralGenerator;
using System;
using System.Collections.Generic;

namespace RomanNumeralGeneratorTest
{
    [TestClass]
    public class RomanNumeralTest
    {
        [TestMethod]
        public void ItReturnsCorrectValuesForValidStrings()
        {
            Dictionary<string, int> testValues = new Dictionary<string, int>() {
                {"I", 1 },
                {"IX", 9  },
                {"Xi", 11 },
                {"MMXV", 2015 },
                {"MCMXCIX", 1999 }
            };

            int retVal;

            foreach (var key in testValues.Keys)
            {
                retVal = 0;
                retVal = GenerateRomanNumerals.ConvertRomanNumerals(key);
                Assert.IsTrue(retVal == testValues[key]);
            }
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ItDoesntAddNonRomanNumerals()
        {
            GenerateRomanNumerals.ConvertRomanNumerals("ki");
        }
    }
}
