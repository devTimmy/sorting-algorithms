using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    /// <summary>
    /// Use this interface to implement concrete algorithm classes such as <see cref="QuickSort"/>, 
    ///  or <seealso cref="MergeSort"/>
    /// 
    /// Note: It only works with specific algorithms and not the base <see cref="SortingAlgorithm"/>
    /// class that all sorting algorithms inherit from.
    /// </summary>
    public interface ISortingAlgorithm : ISorting
    {
        /// <summary>
        /// Sorts an array of integers in <see cref="SortingOrder.Ascending"/> order using
        /// the default sort method provided <see cref="System.Linq"/>
        /// </summary>
        /// <returns>Summary results for the sorting process. <see cref="SortResult"/></returns>
        new SortResult Sort();
        /// <summary>
        /// Sorts an array of integers in <see cref="SortingOrder.Ascending"/> order using
        /// the default sort method provided <see cref="System.Linq"/>
        /// </summary>
        /// <param name="order">Order to use in sorting array either in
        /// ascending or descending order.
        /// </param>
        /// <returns>Summary results for the sorting process. <see cref="SortResult"/></returns>
        new SortResult Sort(SortingOrder order);
    }
}
