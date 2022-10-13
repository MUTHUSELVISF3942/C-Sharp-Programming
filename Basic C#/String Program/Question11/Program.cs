using System;
namespace Question11;
class Program
{
    public static void Main(string[] args)
    {
         String str1;
      str1 = "aaaaaabbbbccc";
      Console.WriteLine("Original String: " + str1);
      Console.WriteLine("Length of the longest substring without repeating characters of the said string:");
      Console.WriteLine(longest_Palindrome(str1));
      str1 = "BDEFGAABEF";
      Console.WriteLine("Original String: " + str1);
      Console.WriteLine("Length of the longest substring without repeating characters of the said string:");;
      Console.WriteLine(longest_Palindrome(str1));
      str1 = "Python";
      Console.WriteLine("Original String: " + str1);
      Console.WriteLine("Length of the longest substring without repeating characters of the said string:");
      Console.WriteLine(longest_Palindrome(str1));
      str1 = "Java";
      Console.WriteLine("Original String: " + str1);
      Console.WriteLine("Length of the longest substring without repeating characters of the said string:");
      Console.WriteLine(longest_Palindrome(str1));
    }

    public static string longest_Palindrome(string s) {
      var chars_array = s.ToCharArray();
      var bool_arr = new bool[chars_array.Length, chars_array.Length];
      int longest_start = 0;
      int max_length = 1;
      for (int i = 0; i < chars_array.Length; i++) {
        bool_arr[i, i] = true;
      }
      for (int i = 0; i < chars_array.Length - 1; i++) {
        if (chars_array[i] == chars_array[i + 1]) {
          bool_arr[i, i + 1] = true;
          longest_start = i;
          max_length = 2;
        }
      }
      for (int length = 3; length <= chars_array.Length; length++) {
        for (int i = 0; i < chars_array.Length - length + 1; i++) {
          int j = i + length - 1;
          if (chars_array[i] == chars_array[j] && bool_arr[i + 1, j - 1]) {
            bool_arr[i, j] = true;
            if (max_length < (j - i)) {
              max_length = j - i;
              longest_start = i;
            }
          }
        }
      }
      return s.Substring(longest_start, max_length);
    }
    }
}