using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rearran
{
    internal class rearrangement
    {
        static int swapCount = 0;
        public static void InsertionSort(int[] array)
        {

            for (int i = 1; i < array.Length; i++)
            {
                int k = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > k)
                {
                    array[j + 1] = array[j];
                    array[j] = k;
                    j--;
                }
            }
            PrintArray(array);
            swap_rearr();
        }

        public static int swap_rearr()
        {
            return swapCount;
        }

        public static void PrintArray(int[] array)
        {
            StreamWriter rearr_array = new StreamWriter("C:\\Users\\vittm\\source\\repos\\Console_sort\\rearr_array.txt");
            for (int i = 0; i < array.Length; i++)
            {
                rearr_array.Write(array[i] + " ");
            }
            rearr_array.Close();
        }
    }
}
