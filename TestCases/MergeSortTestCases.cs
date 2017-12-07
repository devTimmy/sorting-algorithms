using NUnit.Framework;
using SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestCases
{
    public class MergeSortTestCases
    {
        private ISortingAlgorithm _sorting;

        public MergeSortTestCases()
        {
            _sorting = new MergeSort();     
        }

        [Test]
        public void MergeSortCtorTest()
        {
            _sorting = new MergeSort();
        }

        [Test, TestCaseSource(typeof(TestDataSource), "InitCountCases")]
        public void AscMergeSort(int count)
        {
            _sorting.Initialize(count);
            SortResult result = _sorting.Sort();
            Assert.IsNotNull(result);
        }

        [Test, TestCaseSource(typeof(TestDataSource), "InitCountCases")]
        public void DescMergeSort(int count)
        {
            _sorting.Initialize(count);
            SortResult result = _sorting.Sort(SortingOrder.Descending);
            Assert.IsNotNull(result);
        }

    }
}
