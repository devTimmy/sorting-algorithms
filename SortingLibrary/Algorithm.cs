using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    /// <summary>
    /// In computer science, a sorting algorithm is an algorithm that puts elements of a list 
    /// in a certain order. This enumeration contains a list of sorting algorithms implemented 
    /// in this library.
    /// </summary>
    public enum Algorithm
    {
        /// <summary>
        /// Developed by Tony Hoare in 1959, Quick sort is an efficient sorting algorithm
        /// which can perform two or three times faster than its competitors <see cref="Merge"/> sort, and
        /// <seealso cref="Heap"/> sort when implemented well.
        /// 
        /// Time Complexity:
        /// 
        /// Worst Case --> O(n^2)
        /// Best Case  --> O(n log n)
        /// 
        /// Animated simulation of Quick Sort in action:
        /// https://en.wikipedia.org/wiki/Quicksort#/media/File:Sorting_quicksort_anim.gif
        /// </summary>
        Quick,
        /// <summary>
        /// Merge sort is a divide and conquer algorithm that was invented by John Von Newmann
        /// in 1945. It works by dividing unsorted list into n sublists repeatedly, each containing 1 element
        /// (a list of 1 element is considered sorted) then merging all the sublists.
        /// 
        /// Time Complexity:
        /// 
        /// Worst Case --> O(n log n)
        /// Best Case  --> O(n log n) typical
        ///            --> O(n) natural invariant
        ///            
        /// Animated simulation of Merge Sort in action:
        /// https://en.wikipedia.org/wiki/Merge_sort#/media/File:Merge_sort_animation2.gif
        /// </summary>
        Merge,
        /// <summary>
        /// Heap sort was invented by J.W.J Williams in 1964. It divides its input into a sorted and
        /// an unsorted region, and it relatively shrinks the unsorted region by extracting the largest
        /// element and moving that to the sorted region. It uses the Heap data structure rather
        /// than a linear-time search to find the maximum.
        /// 
        /// Time Complexity:
        /// 
        /// Worst Case: --> O(n log n)
        /// Best Case:  --> O(n)
        /// 
        /// Animated simulation of Heap Sort in action:
        /// https://en.wikipedia.org/wiki/Heapsort#/media/File:Sorting_heapsort_anim.gif
        /// </summary>
        Heap,
        /// <summary>
        /// Selection sort algorithm works by dividing the input list into two parts: sorted sub-list
        /// from left to right and unsorted sub-list. The algorithm proceeds by finding the smallest(or
        /// largest, depending on sorting order) element in the unsorted sub-list, exchanging(swapping)
        /// it with the leftmost unsorted element, and moving the sublist boundaries on element
        /// to the right
        /// 
        /// Time Complexity:
        /// 
        /// Worst Case: --> O(n^2) comparisons,
        ///             --> O(n) swaps
        /// Best Case:  --> O(n^2) comparisons,
        ///             --> O(n) swaps
        ///             
        /// Animated simulation of Selection Sort in action:
        /// https://en.wikipedia.org/wiki/Selection_sort#/media/File:Selection_sort_animation.gif
        /// </summary>
        Selection,
        /// <summary>
        /// Radix sort dates back as far as 1887 to the work of Herman Hollerith on tabulating machine.
        /// It is a non-comparative integer sorting algorithm that sorts data with integer keys by
        /// grouping keys by their individual digits which share the same significant position and
        /// value.
        /// 
        /// <list type="bullet">
        ///     <listheader>Two classifications of radix sorts are:</listheader>
        ///     <item>
        ///         <term>
        ///             LSD (Least Significant Digit)
        ///         </term>
        ///         <description>
        ///             Typically implements an order where short keys come before longer keys, and
        ///             keys of the same length are sorted lexicographically(also known as lexical order,
        ///              dictionary order or alphabetical order).
        ///         </description>
        ///     </item>
        ///     <item>
        ///         <term>
        ///             MSD (Most Significant Digit)
        ///         </term>
        ///         <description>
        ///             Uses lexicographic order, which is suitable for sorting strings, such as words,
        ///             or fixed-length integer representations.
        ///         </description>
        ///     </item>
        /// </list>
        /// 
        /// Time Complexity:
        /// Worst Case: --> O(nk) where k represents keys
        /// Best Case:  --> Ω(nk)
        /// 
        /// Radix sort(LSD) simulation video:
        /// https://www.youtube.com/watch?v=LyRWppObda4&index=12&list=PLZh3kxyHrVp_AcOanN_jpuQbcMVdXbqei
        /// Radix sort(MSD) simulation video:
        /// https://www.youtube.com/watch?v=Tmq1UkL7xeU&index=13&list=PLZh3kxyHrVp_AcOanN_jpuQbcMVdXbqei
        /// </summary>
        Radix,
        /// <summary>
        /// Bubble sort, sometimes referred to as stinking sort, is a simple sorting algorithm that
        /// repeatedly steps through the list to be sorted, compares each pair of adjacent items and
        /// swaps them if they are in the wrong order. The pass through the list is repeated until
        /// on swaps are needed. It is often too slow and impractical for most problems even when
        /// compared to <see cref="Insertion"/> sort.
        /// 
        /// Time Complexity:
        /// Worst Case --> O(n^2)
        /// Best Case  --> O(n)
        /// 
        /// Animated simulation of Bubble Sort in action:
        /// https://it.wikipedia.org/wiki/Bubble_sort#/media/File:Sorting_bubblesort_anim.gif
        /// </summary>
        Bubble,
        /// <summary>
        /// Insertion sort is a simple algorithm that builds the final sorted array one item at 
        /// a time. It is much less efficient on large lists than more advanced algorithms such as
        /// <see cref="Quick"/> sort, 
        /// <see cref="Heap"/> sort, or 
        /// <seealso cref="Merge"/> sort.
        /// 
        /// Time Comlexity:
        /// Worst Case: --> O(n^2) comparisons, swaps
        /// Best Case:  --> O(n) comparisons
        ///             --> O(1) swaps
        ///             
        /// Animated simulation of Insertion Sort in action:
        /// https://en.wikipedia.org/wiki/Insertion_sort#/media/File:Insertion_sort.gif
        /// </summary>
        Insertion
    }
}
