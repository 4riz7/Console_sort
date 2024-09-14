using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selections
{
    internal class selection
    {
        static ulong swapCount = 0;

        public static void SelectionSort(int[] array)
        {
            swapCount = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    // Обмен элементов
                    int tmp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = tmp;
                    swapCount++;
                }
            }
            PrintArray(array);
        }


        public static ulong swap_select()
        {
            return swapCount;
        }

        public static void PrintArray(int[] array)
        {
            StreamWriter selection_array = new StreamWriter("Путь к вашему файлу");
            for (int i = 0; i < array.Length; i++)
            {
                selection_array.Write(array[i] + " ");
            }
            selection_array.Close();
        }
    }
}
