using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktail_Sort
{ 
    internal class cocktail
    {
        static ulong swapCount = 0;

        public static void CocktailSort(int[] array)
        {
            swapCount = 0;
            bool swapped = true;
            int start = 0;
            int end = array.Length - 1;

            while (swapped)
            {
                swapped = false;
                for (int i = start; i < end; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        // Обмен элементов
                        int tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                        swapCount++;
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;

                swapped = false;
                end--;

                for (int i = end - 1; i >= start; i--)
                {
                    if (array[i] > array[i + 1])
                    {
                        // Обмен элементов
                        int tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                        swapCount++;
                        swapped = true;
                    }
                }

                start++;
            }
            PrintArray(array);
        }



        public static ulong swap_cocktail()
        {
            return swapCount;
        }

        public static void PrintArray(int[] array)
        {
            StreamWriter cocktail_array = new StreamWriter("C:\\Users\\vittm\\source\\repos\\Console_sort\\cocktail_array.txt");
            for (int i = 0; i < array.Length; i++)
            {
                cocktail_array.Write(array[i] + " ");
            }
            cocktail_array.Close();
        }
    }
}