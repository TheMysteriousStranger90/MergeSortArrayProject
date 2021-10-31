using System;
using MergeSortArrayClassLibrary;
using static System.Console;

namespace MergeSortArrayProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var example1 = new int[] {1, 2, 3, 5, 4};
            var example2 = new int[] {-5, 67, 32, 5, 1};
            ShowConsoleResults(example1, example2);

            ReadKey();
        }

        private static void FormatedWriteLine(int[] arr) => WriteLine($"Array: {{ {string.Join(",", arr)} }}");

        private static void ShowConsoleResults(params int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                FormatedWriteLine(arr[i]);
                MergeSortArray.MergeMethod(ref arr[i]);
                FormatedWriteLine(arr[i]);
            }
        }
    }
}