using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 *  Worst Case Complexity: O(n*n). This type of case occurs when elements of the array are sorted in reverse order. Thus each element of the array is visited twice.
  
 *  Average Case Complexity: This case is similar to Worst case complexity as in this case array is half sorted. Thus loops are run through half the array. Thus complexity is O(n2).
  
 *  Best Case Time Complexity: O(n). When elements of the array are already sorted, then complexity includes the time to loop through all elements once. Thus it takes linear time in the Best case.
  
 *  Auxiliary Space: O(1) – As Bubble Sort requires no extra space for storing intermediate results; thus, almost no auxiliary space is required.
 
    The main disadvantage of Bubble sort can be seen while dealing with an array containing a huge number of elements. As worst-case complexity of this algorithm is O(n2), thus a lot more time is taken to sort them. Thus it is more suitable for teaching sorting algorithms instead of real-life applications.


 */



namespace ConsoleApp5
{
  internal class BubbleSortAlgo
  {
    public static void Main()
    {
      int[] arr = { 1, 5, 4, 11, 20, 8, 2, 98, 90, 16 };
      int[] arr1 = { 1, 5, 4, 11, 20, 8, 2, 98, 90, 16 };
      var result = BubbleSortAlgorithemASC(arr);
      var result1 = BubbleSortAlgorithemDESC(arr1);

      Console.WriteLine("ASC Order");
      foreach (int i in result)
      {
        Console.Write(i + " ");
      }

      Console.WriteLine();
      Console.WriteLine("DESC Order");
      foreach (int i in result1)
      {
        Console.Write(i + " ");
      }
    }

    public static int[] BubbleSortAlgorithemASC(int[] arr)
    {
      for (int i = 0; i < arr.Length; i++)
      {
        for (int j = i + 1; j < arr.Length; j++)
        {
          if (arr[j] > arr[i])
          {
            var temp = arr[j];
            arr[j] = arr[i];
            arr[i] = temp;
          }
        }
      }
      return arr;
    }

    public static int[] BubbleSortAlgorithemDESC(int[] arr)
    {
      for(int i = 0; i < arr.Length; i++)
      {
        for(var j = i + 1;j < arr.Length; j++)
        {
          if(arr[j] < arr[i])
          {
            var temp = arr[j];
            arr[j] = arr[i];
            arr[i] = temp;
          }
        }
      }
      return arr;
    }
  }
}
