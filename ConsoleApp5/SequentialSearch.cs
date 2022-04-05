using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
 * 
 * Sequential Search is also known as leaner search ..
 * in this we search element as one by one itration ---
 * 
 * Space Complexity --- O(n) this search is not using extra space.it is taking n number of space.
 * 
 * Wrost Case Complexity -- O(n) if search result not present in array.
 * Best Case Complexity -- O(1)  if search result present in first position.
 * Average Case Complexity -- O(n) if search element is present in middle of array.
 * 
 */



namespace ConsoleApp5
{
  public class SequentialSearch
  {
    public static void Main()
    {
      int[] arr = { 1,2,4,6,7,8,7,56,78,78};
      var len = arr.Length;
      int findValue = 8;
      var result = SequentialSearchAlgo(arr, len, findValue);
      Console.WriteLine($"Position of search value { findValue } element is { result}");
    }

    public static int SequentialSearchAlgo(int[] arr, int len, int value)
    {
      for (int i = 0; i < len-1; i++)
      {
        if(arr[i] == value)
        {
          return i;
        }
      }
      return -1;
    }
  }
}
