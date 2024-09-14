using System;
using System.IO;

namespace BubbleSort
{
    public class Sorting
    {
        // Метод, сортирующий массив целых чисел (по возрастанию)
        public static void Bubble_Sort(int[] array_b)
        {
            for (int i = 0; i < array_b.Length; i++)
            {
                for (int j = 0; j < array_b.Length - 1 - i; j++)
                {
                    if (array_b[j] > array_b[j + 1])
                    {
                        Swap(ref array_b[j], ref array_b[j + 1]);
                    }
                }
            }
            PrintArray(array_b);
        }

        // Вспомогательный метод для обмена элементов массива
        static ulong swaps = 0;
        static void Swap(ref int firstArg, ref int secondArg)
        {
            int tmp = firstArg;
            firstArg = secondArg;
            secondArg = tmp;
            ++swaps;
        }


        public static ulong swaps_Bubble() 
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
