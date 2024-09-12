using System;
using System.IO;

namespace BubbleSort
{
    public class Sorting
    {
        // Метод, сортирующий массив целых чисел (по возрастанию)
        public static void Bubble_Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap( array[j], array[j + 1]);
                    }
                }
            }
            PrintArray(array);
        }

        // Вспомогательный метод для обмена элементов массива
        static int swaps = 0;
        public static void Swap(int firstArg, int secondArg)
        {
            int tmp = firstArg;
            firstArg = secondArg;
            secondArg = tmp;
            ++swaps;
        }

        public static int swaps_Bubble() 
        { 
            return swaps;
        }

        // Метод для вывода элементов массива на консоль
        public static void PrintArray(int[] array)
        {
            StreamWriter Bubble_array = new StreamWriter("C:\\Users\\vittm\\source\\repos\\Console_sort\\Bubble_array.txt");
            for (int i = 0; i < array.Length; i++)
            {
                Bubble_array.Write(array[i] + " ");
            }
            Bubble_array.Close();
        }

    }
}
