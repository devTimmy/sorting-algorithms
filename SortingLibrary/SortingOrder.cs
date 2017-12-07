using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    /// <summary>
    /// Ordering is basically a set of rules that determine what items come before, or after, other
    /// elements in some sequence.
    /// </summary>
    public enum SortingOrder
    {
        /// <summary>
        /// Elements are said to be in <see cref="Ascending"/> order when they are arranged from the least
        /// significant item or most minimum alphabetically to most significant or most maximum
        /// alphabetically.
        /// 
        /// <example>
        ///     Numbers are said to be in <see cref="Ascending"/> order when they are arranged from
        ///     the smallest to the largest number. e.g 5,9,13,17..21
        /// </example>
        /// </summary>
        Ascending,
        /// <summary>
        /// Elements are said to be in <see cref="Descending"/> order when they are arranged from
        /// the most significant item or most maximum alphabetically to the least significant or
        /// minimum alphabetically
        /// 
        /// <example>
        ///     Numbers are said to be in descending order when they are arranged from the largest
        ///     to the smallest number. e.g 25,21,17,13,9..5
        /// </example>
        /// </summary>
        Descending
    }
}
