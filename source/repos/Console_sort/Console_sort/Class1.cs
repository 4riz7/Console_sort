using System;
using System.Diagnostics;
using BubbleSort; 
using System.IO;
using Main_Array;
using Rearran;

namespace Console_sort
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int dimensionality = 100000000;
            int[] array_b = create.crt_m_array(dimensionality);

            int[] array_r = (int[])array_b.Clone(); // Глубокая копия массива

            Bubble(array_b);

            void Bubble(int[] array)
            {
                Stopwatch stopwatch_Bubble = Stopwatch.StartNew();
                Sorting.Bubble_Sort(array);
                stopwatch_Bubble.Stop();
                ulong swap_Bubble = Sorting.swaps_Bubble();
                Console.WriteLine($"Время выполнения сортировки пузырьковым методом: {stopwatch_Bubble.ElapsedMilliseconds} мс\n Количество перестановок: {swap_Bubble}");
            }

            Rearr(array_r);

            void Rearr(int[] array)
            {
                Stopwatch stopwatch_rearrangement = Stopwatch.StartNew();
                rearrangement.InsertionSort(array);
                stopwatch_rearrangement.Stop();
                ulong swap_rearr = rearrangement.swap_rearr();
                Console.WriteLine($"Время выполнения сортировки методом перестановки: {stopwatch_rearrangement.ElapsedMilliseconds} мс\n Количество перестановок: {swap_rearr}");
            }

            Console.ReadLine();
            Console.ReadKey();
        }

    }
}
