using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
  internal class SortestElement
  {
    public static void Main()
    {
      int[] arr = { 4, 56, 7, 2, 5, 6, 9, 1, 57 };
      // using temp variable 
      int result = FindSmallest(arr);
      Console.WriteLine($"Smallest element {result}");
      int result1 = FindGretest(arr);
      Console.WriteLine($"Smallest element {result1}");

      //  using sort function
      Array.Sort(arr);
      Console.WriteLine();
      foreach (int i in arr)
      {
        Console.Write(i + " ");
      }

      Array.Reverse(arr);
      Console.WriteLine();
      foreach (int i in arr)
      {
        Console.Write(i + " ");
      }
    }

    public static int FindSmallest(int[] arr)
    {
      int temp;
      for (int i = 0; i < arr.Length; i++)
      {
        for (int j = i + 1; j < arr.Length; j++)
        {
          if (arr[i] > arr[j])
          {
            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
          }
        }
      }
      return arr[0];
    }

    public static int FindGretest(int[] arr)
    {
      int temp;
      for (int i = 0; i < arr.Length; i++)
      {
        for (int j = i + 1; j < arr.Length; j++)
        {
          if (arr[i] > arr[j])
          {
            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
          }
        }
      }
      return arr[arr.Length - 1];
    }
  }



}
