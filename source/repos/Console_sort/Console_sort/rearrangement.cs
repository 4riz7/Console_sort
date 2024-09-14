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
        static ulong swapCount = 0;

        public static void InsertionSort(int[] array)
        {
            swapCount = 0;  // Сбрасываем счетчик перед сортировкой
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                    swapCount++;  // Увеличиваем счетчик перестановок
                }
                array[j + 1] = key;
            }

            PrintArray(array);  // Запись в файл
        }

        public static ulong swap_rearr()
        {
            return swapCount;
        }

        public static void PrintArray(int[] array)
        {
            StreamWriter rearr_array = new StreamWriter("Путь к вашему файлу");
            for (int i = 0; i < array.Length; i++)
            {
                rearr_array.Write(array[i] + " ");
            }
            rearr_array.Close();
        }
    }
}
