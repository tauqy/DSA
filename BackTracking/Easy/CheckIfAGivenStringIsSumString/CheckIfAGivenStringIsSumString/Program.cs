/*
 * "12243660" is a sum string
 * Explanation: 12+24=36, 24+36=60
 *"2368" is not a sum string
 */

/*
 * Explanation
 * sub-string(i,x)+sub(x+1,j)=sub-string(j+1,l)
 */

using CheckIfAGivenStringIsSumString;

SumString sumString = new SumString();
Console.WriteLine(sumString.IsSumString("12243660"));
Console.WriteLine(sumString.IsSumString("2368"));