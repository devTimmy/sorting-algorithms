using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace SortingAlgorithms
{
    /// <summary>
    /// Base class that all sorting algorithms should inherit from
    /// </summary>
    public class SortingAlgorithm : ISorting
    {
        /// <summary>
        /// Initial number of integers to generate in the <see cref="Values"/> list
        /// in case user does not provide their own array.
        /// </summary>
        private int _defaultCount = 0;
        private IList<int> _values;
        private Random _random;
        private int _swaps;
        private int _iterations;
        private int _stepThroughs;
        private int _comparisons;
        private Stopwatch _stopWatch;

        /// <summary>
        /// Constructor to initialize this class
        /// </summary>
        public SortingAlgorithm()
        {
            _defaultCount = 5000;
            _values = new List<int>();
            _random = new Random();
            _stopWatch = new Stopwatch();

            InitializeComponent();
        }

        /// <summary>
        /// A list of all integer values in the <see cref="_unsorted"/> 
        /// list array.
        /// </summary>
        public IList<int> Values
        {
            get
            {
                return _values;
            }
            set
            {
                _values = value;
            }
        }
        /// <summary>
        /// Total number of swaps made in sorting array
        /// </summary>
        public int Swaps
        {
            get { return _swaps; }
            set { _swaps = value; }
        }
        /// <summary>
        /// Total number of stepthroughs made in the array
        /// </summary>
        public int Iterations
        {
            get { return _iterations; }
            set { _iterations = value; }
        }
        public Stopwatch Stopwatch => _stopWatch;
        public int StepThroughs
        {
            get { return _stepThroughs; }
            set { _stepThroughs = value; }
        }
        public int Comparisons
        {
            get { return _comparisons; }
            set { _comparisons = value; }
        }
        
        /// <summary>
        /// Generates the first default number of integers and inserts them
        /// into the unsorted array.
        /// </summary>
        private void InitializeComponent()
        {
            for (int i = 0; i < _defaultCount; i++)
            {
                _values.Add(_random.Next(0, _defaultCount));
            }
        }

        public void Initialize(int count)
        {
            _defaultCount = count;
            _values = new List<int>();

            InitializeComponent();
        }


        /// <summary>
        /// Contains all the basic methods that all sorting algorithms use
        /// or should implement or override to provide their own functionality.
        /// </summary>
        #region Virtual Methods that can be Overriden
        public virtual void Sort()
        {
            _values = _values.OrderBy(x => x)
                               .ToArray();
        }
        public virtual void Sort(SortingOrder order)
        {
            switch (order)
            {
                case SortingOrder.Ascending:
                    Sort();
                    break;
                case SortingOrder.Descending:
                    _values = _values.OrderByDescending(x => x)
                                       .ToArray();
                    break;
                default:
                    break;
            }
        }
        public virtual SortResult Sort(Algorithm algorithm)
        {
            return new SortResult(false, 0, 0,0,0, TimeSpan.MinValue);
        }
        public virtual SortResult Sort(Algorithm algorithm, SortingOrder order)
        {
            return new SortResult(false, 0, 0,0,0, TimeSpan.MinValue);
        }
        #endregion
    }
}
