using System;
using System.IO;

namespace Quick_Sort
{
    internal class quick
    {
        static ulong swapCount = 0;

        // Основной метод быстрой сортировки
        public static void QuickSort(int[] array)
        {
            swapCount = 0;
            QuickSortHelper(array, 0, array.Length - 1);
            PrintArray(array);
        }

        // Рекурсивный вспомогательный метод
        private static void QuickSortHelper(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(array, low, high);
                QuickSortHelper(array, low, pivotIndex - 1);
                QuickSortHelper(array, pivotIndex + 1, high);
            }
        }

        // Метод разделения массива и выбор опорного элемента
        private static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(ref array[i], ref array[j]);
                }
            }

            Swap(ref array[i + 1], ref array[high]);
            return i + 1;
        }

        // Вспомогательный метод для обмена элементов массива
        private static void Swap(ref int firstArg, ref int secondArg)
        {
            int temp = firstArg;
            firstArg = secondArg;
            secondArg = temp;
            swapCount++;
        }

        // Метод для записи отсортированного массива в файл
        public static void PrintArray(int[] array)
        {
            StreamWriter quick_array = new StreamWriter("C:\\Users\\vittm\\source\\repos\\Console_sort\\quick_array.txt");
            for (int i = 0; i < array.Length; i++)
            {
                quick_array.Write(array[i] + " ");
            }
            quick_array.Close();
        }

        // Метод для получения количества перестановок
        public static ulong swap_quick()
        {
            return swapCount;
        }
    }
}
