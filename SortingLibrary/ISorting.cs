using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    /// <summary>
    /// This interface provides you with a contract to interact with a 
    /// sorting algorithm of you choosing and perform all the functions/methods
    /// of a sorting algorithm
    /// </summary>
    public interface ISorting
    {
        /// <summary>
        /// Initialize the sorting algorithm with an array of <paramref name="count"/>
        /// integers for testing or simulation purposes.
        /// </summary>
        /// <param name="count">Numbers of integers to generate in your initial array</param>
        void Initialize(int count);

        /// <summary>
        /// Sorts an array of integers in <see cref="SortingOrder.Ascending"/> order using
        /// the default sort method provided <see cref="System.Linq"/>
        /// </summary>
        void Sort();
        /// <summary>
        /// Sorts an array of integers according the <paramref name="order"/> you choose.
        /// For further details about <see cref="SortingOrder"/>
        /// </summary>
        /// <param name="order">Either ascending or descending order. <see cref="SortingOrder"/></param>
        void Sort(SortingOrder order);
        /// <summary>
        /// Sorts an array of integers in <see cref="SortingOrder.Ascending"/> order using a 
        /// particular sorting <paramref name="algorithm"/>
        /// </summary>
        /// <param name="algorithm">Algorithm to use in sorting the array. <see cref="Algorithm"/></param>
        /// <returns>Summary results for the sorting process. <see cref="SortResult"/></returns>
        SortResult Sort(Algorithm algorithm);
        /// <summary>
        /// Sorts an array of integers either in ascending or descending order as per user chosen
        /// input <paramref name="order"/> and performs sorting operation on array using the
        /// algorithm of choice <paramref name="algorithm"/>.
        /// </summary>
        /// <param name="algorithm">Algorithm to use in sorting the array. <see cref="Algorithm"/></param>
        /// <param name="order">Either ascending or descending order. <see cref="SortingOrder"/></param>
        /// <returns>Summary results for the sorting process. <see cref="SortResult"/></returns>
        SortResult Sort(Algorithm algorithm, SortingOrder order);
    }
}
