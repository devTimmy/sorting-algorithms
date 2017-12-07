using System;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TestCases
{
    public class TestDataSource
    {
        public static IEnumerable InitCountCases
        {
            get
            {
                yield return new TestCaseData(5000);
            }
        }
    }
}
