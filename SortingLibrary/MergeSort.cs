using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class MergeSort : SortingAlgorithm, ISortingAlgorithm
    {
        public MergeSort()
        {
            this.Swaps = 0;
            this.Iterations = 0;
            this.StepThroughs = 0;
            this.Comparisons = 0;
        }
        SortResult ISortingAlgorithm.Sort()
        {
            throw new NotImplementedException();
        }

        SortResult ISortingAlgorithm.Sort(SortingOrder order)
        {
            throw new NotImplementedException();
        }


        private void Divide(int low,int high)
        {
            if(low < high)
            {
                int mid = (low + high) / 2;

                //
            }
        }
        private void Merge(int[] left,int[] right)
        {

        }
        private void Merge(int left,int right)
        {

        }
    }
}
