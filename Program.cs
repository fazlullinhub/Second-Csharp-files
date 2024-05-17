using System;
using System.Text.RegularExpressions;

namespace ConsoleApplication12
{
    class Program
    {
        private static ReadOnlySpan<char> str;
        static void Main(string[] args)
        {
            string[] str = { "I used to eat drugs for ten years" };
            for (int i = 0; i < str.Length; i++)
            {
                if (ValidWordFound(str[i])) Console.WriteLine(str[i] + "*");
            }
            Console.ReadKey();
        }
        static bool ValidWordFound(string word)
        {
            return Regex.IsMatch(str, @"*");
        }
    }
}
