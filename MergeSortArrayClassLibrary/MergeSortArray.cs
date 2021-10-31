using System;
using System.Linq;

namespace MergeSortArrayClassLibrary
{
    public static class MergeSortArray
    {
        public static void MergeMethod(ref int[] arr)
        {
            arr = SortByMergeMethod(arr);
        }
        public static int[] SortByMergeMethod(int[] arr)
        {
            if (arr == null) throw new ArgumentNullException(nameof(arr));
            return arr.Length == 1
                ? arr
                : MergeArrays(SortByMergeMethod(arr.Take(arr.Length / 2).ToArray()),
                    SortByMergeMethod(arr.Skip(arr.Length / 2).ToArray()));
        }

        private static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            int[] sortedArray = new int[arr1.Length + arr2.Length];
            int index1 = 0, index2 = 0, counter = 0;
            for (int i = 0; i < arr1.Length + arr2.Length; i++, counter++)
                if (index1 < arr1.Length)
                    if (index2 < arr2.Length)
                        if (arr1[index1] < arr2[index2]) sortedArray[counter] = arr1[index1++];
                        else sortedArray[counter] = arr2[index2++];
                    else sortedArray[counter] = arr1[index1++];
                else sortedArray[counter] = arr2[index2++];
            return sortedArray;
        }
    }
}