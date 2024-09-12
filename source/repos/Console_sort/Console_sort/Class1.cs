using System;
using System.Diagnostics;
using BubbleSort; // Подключение пространства имен BubbleSort
using System.IO;
using Main_Array;
using Rearran;

namespace Console_sort
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            // Создаем массив и записываем его в файл main_array
            int dimensionality = 1000;
            int[] array_b = create.crt_m_array(dimensionality);
            int[] array_r = array_b;
 

            Bubble(array_b);
            
            
            void Bubble(int[] array)
            {
                // Сортируем методом пузырьковой сортировки
                Stopwatch stopwatch_Bubble = Stopwatch.StartNew();
                Sorting.Bubble_Sort(array);
                stopwatch_Bubble.Stop();
                int swap_Bubble = Sorting.swaps_Bubble();
                Console.WriteLine($"Время выполнения сортировки пузырьковым методом: {stopwatch_Bubble.ElapsedMilliseconds} мс\n Количество перестановок: {swap_Bubble}");
            }
           
            Rearr(array_r);

            void Rearr(int[] array)
            {
                // Сортируем методом перестановки 
                Stopwatch stopwatch_rearrangement = Stopwatch.StartNew();
                rearrangement.InsertionSort(array);
                stopwatch_rearrangement.Stop();
                int swap_rearr = rearrangement.swap_rearr();
                Console.WriteLine($"Время выполнения сортировки методом перестановки: {stopwatch_rearrangement.ElapsedMilliseconds} мс\n Количество перестановок: {swap_rearr}");
            }
            

            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
