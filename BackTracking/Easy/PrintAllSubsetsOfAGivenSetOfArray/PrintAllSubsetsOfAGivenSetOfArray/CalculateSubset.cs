using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAllSubsetsOfAGivenSetOfArray
{
    public class CalculateSubset
    {
        public IList<IList<int>> SubSet(IList<int> arr)
        {
            List<int> subset = new List<int>();
            List<IList<int>> res = new List<IList<int>>();
            int index = 0;
            CalcSubset(arr, res, subset, index);
            return res;
        }

        private void CalcSubset(IList<int> arr, IList<IList<int>> res, List<int> subset, int index)
        {
            //Add the current to the result list
            res.Add(new List<int>(subset));

            //Generate subsets by recursively including and excluding elements
            for (int i = index; i < arr.Count; i++)
            {
                //Include the current element in the subset
                subset.Add(arr[i]);
                //Recursively generate subsets with the current element included
                CalcSubset(arr, res, subset, i + 1);
                //Exclude the current element with the current element included
                subset.RemoveAt(subset.Count - 1);
            }
        }
    }
}
