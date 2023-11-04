/*
 * INPUT: N=3, Arr=[1,2,3]
 * OUTPUT: {}, {1},{1,2}, {1,3}, {2}, {2,3}, {3}, {1,2,3}
 */

using PrintAllSubsetsOfAGivenSetOfArray;

CalculateSubset subset = new CalculateSubset();
var arr = new List<int> { 1, 2, 3 };
var res = subset.SubSet(arr);
foreach (var item in res)
{
    Console.WriteLine(String.Join(" ", item));
}