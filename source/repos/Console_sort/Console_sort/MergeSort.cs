using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sort
{
    internal class merge
    {
        static ulong swapCount = 0;

        public static void MergeSort(int[] array)
        {
            MergeSortHelper(array, 0, array.Length - 1);
            PrintArray(array);
        }

        static void MergeSortHelper(int[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSortHelper(array, left, mid);
                MergeSortHelper(array, mid + 1, right);
                Merge(array, left, mid, right);
            }
        }

        static void Merge(int[] array, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            Array.Copy(array, left, leftArray, 0, n1);
            Array.Copy(array, mid + 1, rightArray, 0, n2);

            int i = 0, j = 0, k = left;
            while (i < n1 && j < n2)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    array[k++] = leftArray[i++];
                }
                else
                {
                    array[k++] = rightArray[j++];
                    swapCount++;
                }
            }

            while (i < n1)
            {
                array[k++] = leftArray[i++];
            }

            while (j < n2)
            {
                array[k++] = rightArray[j++];
            }
        }

        public static ulong swap_merge()
            {
                return swapCount;
            }

        public static void PrintArray(int[] array)
        {
            StreamWriter merge_array = new StreamWriter("C:\\Users\\vittm\\source\\repos\\Console_sort\\merge_array.txt");
            for (int i = 0; i < array.Length; i++)
            {
                merge_array.Write(array[i] + " ");
            }
            merge_array.Close();
        }
    }
}