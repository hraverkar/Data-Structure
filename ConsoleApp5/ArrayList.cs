using System.Collections;

namespace ConsoleApp5
{
  /*
   * Array -> Defined data with same type.
   * Array length is defined 
   * 
   * ArrayList -> Dynamic Data with any type.
   * 
   */
  internal class ArrayList
  {
    public static void Main()
    {
      string[] array = new string[10];
      array[0] = "Hello";
      array[1] = "Harshal";
      array[2] = "Raverkar";

      foreach (var i in array)
      {
        Console.WriteLine(i);
      }

      List<string> list = new List<string>();
      list.Add("Hello");
      list.Add("Raverkar");
      list.Add((string)null);

      foreach (var i in list)
      {
        Console.WriteLine(i);
      }

      SortedList<int, string> keyValuePairs = new SortedList<int, string>();
      keyValuePairs.Add(1, "Monday");
      keyValuePairs.Add(2, "Tuesday");
      keyValuePairs.Add(3, "Wednesday");
      keyValuePairs.Add(4, "Thursday");
      keyValuePairs.Add(5, "Friday");
      keyValuePairs.Add(6, "Sturday");
      keyValuePairs.Add(7, "Sunday");
      keyValuePairs.Add(8, "test1");

      bool ret = keyValuePairs.ContainsKey(5);
      Console.WriteLine(ret);

      bool pet = keyValuePairs.ContainsValue("Sunday");
      Console.WriteLine(pet);

    }
  }
}
