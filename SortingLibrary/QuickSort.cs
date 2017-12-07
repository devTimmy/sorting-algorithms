using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    /// <summary>
    /// Implements QuickSort algorithm.
    /// 
    /// <see cref="Algorithm.Quick"/>
    /// </summary>
    public class QuickSort : SortingAlgorithm, ISortingAlgorithm
    {

        public QuickSort()
        {
            this.Swaps = 0;
            this.Iterations = 0;
            this.StepThroughs = 0;
            this.Comparisons = 0;
        }

        public override void Sort()
        {
            quickSort(0, this.Values.Count-1, SortingOrder.Ascending);
        }

        public override void Sort(SortingOrder order)
        {
            quickSort(0, this.Values.Count - 1, order);
        }


        private void quickSort(int left,int right,SortingOrder order)
        {
            if(left < right)
            {
                int pi = Partition(left, right,order);

                quickSort(left, pi - 1,order);
                quickSort(pi + 1, right,order);
            }
        }
        private int Partition(int left,int right,SortingOrder order)
        {
            this.Iterations++;

            int pivot = this.Values[right];
            int i = (left - 1);

            for (int j = left; j <= right-1; j++)
            {
                this.StepThroughs++;

                switch (order)
                {
                    case SortingOrder.Ascending:
                        if (this.Values[j] <= pivot)
                        {
                            i++;
                            this.Comparisons++;
                            Swap(i, j);
                        }
                        break;
                    case SortingOrder.Descending:
                        if (this.Values[j] >= pivot)
                        {
                            i++;
                            this.Comparisons++;
                            Swap(i, j);
                        }
                        break;
                    default:
                        break;
                }
            }

            Swap(i + 1, right);
            return i + 1;
        }
        private void Swap(int i,int j)
        {
            int left = this.Values[i];

            this.Values[i] = this.Values[j];
            this.Values[j] = left;

            this.Swaps++;
        }

        SortResult ISortingAlgorithm.Sort()
        {
            this.Stopwatch.Restart();

            Task task = Task.Run(() =>
            {
                quickSort(0, this.Values.Count - 1, SortingOrder.Ascending);
            });

            while (!task.IsCompleted)
            {
                task.Wait();
            }

            this.Stopwatch.Stop();

            var result = new SortResult(true, this.Swaps, this.Iterations,this.StepThroughs,this.Comparisons, this.Stopwatch.Elapsed);
            //log
            result.Log();

            return result;
        }

        SortResult ISortingAlgorithm.Sort(SortingOrder order)
        {
            this.Stopwatch.Restart();

            Task task = Task.Run(() =>
            {
                quickSort(0, this.Values.Count - 1, order);
            });

            while (!task.IsCompleted)
            {
                task.Wait();
            }

            this.Stopwatch.Stop();

            var result = new SortResult(true, this.Swaps, this.Iterations, this.StepThroughs, this.Comparisons, this.Stopwatch.Elapsed);
            //log
            result.Log();

            return result;
        }
    }
}
