using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    /// <summary>
    /// This class contains a short summary of an algorithms operation in terms
    /// of all the swaps done, iterations and total time taken in sorting
    /// items in array
    /// </summary>
    public class SortResult
    {
        #region Local Private Readonly Variables
        private readonly bool _complete;
        private readonly int _swaps;
        private readonly int _iterations;
        private readonly int _stepThroughs;
        private readonly int _comparisons;
        private readonly TimeSpan _sortTime;
        #endregion

        /// <summary>
        /// Constructor of <c>SortResult</c> that initializes the class with data results
        /// for a sorting algorithm
        /// </summary>
        /// <param name="completeStatus">Whether the sorting operation completed successfully.</param>
        /// <param name="swaps">Number of exchanges/swaps made between two sub-lists or numbers.</param>
        /// <param name="iterations">Total count of steps in splitting the array into partitions.</param>
        /// <param name="stepThroughs">Step by step movement within a partition comparing numbers.
        /// Total steps made to complete sort.
        /// </param>
        /// <param name="comparisons">Total number of comparisons checking if they
        /// satify the selected pivot at that time.
        /// </param>
        /// <param name="timeSpan">Time taken to sort data as a timespan either in
        /// seconds or milliseconds.
        /// </param>
        public SortResult(bool completeStatus,int swaps,int iterations,int stepThroughs,int comparisons,TimeSpan timeSpan)
        {
            _complete = completeStatus;
            _swaps = swaps;
            _iterations = iterations;
            _stepThroughs = stepThroughs;
            _comparisons = comparisons;
            _sortTime = timeSpan;
        }

        public bool Complete => _complete;
        public int Swaps => _swaps;
        public int Iterations => _iterations;
        public TimeSpan SortTime => _sortTime;
        public int StepThroughs => _stepThroughs;
        public int Comparisons => _comparisons;

        /// <summary>
        /// Logs the results of sorting process to the console
        /// </summary>
        public void Log()
        {
            if (!_complete)
            {
                Console.WriteLine("Sorting Failed!!");
            }
            else
            {
                Console.WriteLine("Sorting Complete!!\n");
                Console.WriteLine("Summary:");
                Console.WriteLine("Iterations --> {0}", _iterations.ToString("###,###"));
                Console.WriteLine("StepThroughs --> {0}", _stepThroughs.ToString("###,###"));
                Console.WriteLine("Comparisons --> {0}", _comparisons.ToString("###,###"));
                Console.WriteLine("Swaps --> {0}", _swaps.ToString("###,###"));
                Console.WriteLine("TimeSpan --> {0} seconds, {1} ms", _sortTime.Seconds, _sortTime.Milliseconds);
            }
        }
    }
}
