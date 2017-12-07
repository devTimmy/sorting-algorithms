using NUnit.Framework;
using SortingAlgorithms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TestCases
{
    public class QuickSortTestCases
    {
        private ISortingAlgorithm _sorting;

        public QuickSortTestCases()
        {
            _sorting = new QuickSort();
        }

        [Test]
        public void QuickSortCtorTest()
        {
            _sorting = new QuickSort();
        }


        [Test, TestCaseSource(typeof(TestDataSource),"InitCountCases")]
        public void InitializeTest(int count)
        {
            _sorting.Initialize(count);
        }

        [Test, TestCaseSource(typeof(TestDataSource), "InitCountCases")]
        public void AscQuickSort(int count)
        {
            _sorting.Initialize(count);
            SortResult result = _sorting.Sort();
            Assert.IsNotNull(result);
        }

        [Test, TestCaseSource(typeof(TestDataSource), "InitCountCases")]
        public void DescQuickSort(int count)
        {
            _sorting.Initialize(count);
            SortResult result = _sorting.Sort(SortingOrder.Descending);
            Assert.IsNotNull(result);
        }
    }
}
