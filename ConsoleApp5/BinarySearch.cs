using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
  internal class BinarySearch
  {
    public static void Main()
    {
      int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
      int value = 15;
      int result = BinarySearchAlgo(arr, value);
      Console.WriteLine($"Position of the item { value } in array is {result}");
      Console.ReadLine();
    }

    public static int BinarySearchAlgo(int[] arr, int value)
    {
      int low = 0;
      int high = arr.Length - 1;

      while (low <= high)
      {
        int mid = (low + high) / 2;
        int guess = arr[mid];
        if (guess == value)
        {
          return mid;
        }
        else if (guess > value)
        {
          high = mid - 1;
        }
        else
        {
          low = mid + 1;
        }
      }
      return 0;
    }
  }
}
