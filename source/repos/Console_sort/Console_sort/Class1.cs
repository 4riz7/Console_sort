using System;
using System.Diagnostics;
using BubbleSort; 
using System.IO;
using Main_Array;
using Rearran;
using Selections;
using Merge_Sort;
using Cocktail_Sort;
using Quick_Sort;

namespace Console_sort
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int dimensionality = 10000;
            int[] array_b = create.crt_m_array(dimensionality);
            int[] array_r = (int[])array_b.Clone(); 
            int[] array_s = (int[])array_b.Clone();
            int[] array_m = (int[])array_b.Clone();
            int[] array_c = (int[])array_b.Clone();
            int[] array_q = (int[])array_b.Clone();


            Stopwatch stopwatch_Bubble = Stopwatch.StartNew();
            Sorting.Bubble_Sort(array_b);
            stopwatch_Bubble.Stop();
            ulong swap_Bubble = Sorting.swaps_Bubble();
            Console.WriteLine($"Время выполнения методом пузырьковой сортировки: {stopwatch_Bubble.ElapsedMilliseconds} мс\n Количество перестановок: {swap_Bubble}");
        

            Stopwatch stopwatch_rearrangement = Stopwatch.StartNew();
            rearrangement.InsertionSort(array_r);
            stopwatch_rearrangement.Stop();
            ulong swap_rearr = rearrangement.swap_rearr();
            Console.WriteLine($"Время выполнения методом сортировки перестановки: {stopwatch_rearrangement.ElapsedMilliseconds} мс\n Количество перестановок: {swap_rearr}");

            Stopwatch stopwatch_selection = Stopwatch.StartNew();
            selection.SelectionSort(array_s);
            stopwatch_selection.Stop();
            ulong swap_select = selection.swap_select();
            Console.WriteLine($"Время выполнения методом сортировки выбора: {stopwatch_selection.ElapsedMilliseconds} мс\n Количество перестановок: {swap_select}");

            Stopwatch stopwatch_merge = Stopwatch.StartNew();
            merge.MergeSort(array_m);
            stopwatch_merge.Stop();
            ulong swap_merge = merge.swap_merge();
            Console.WriteLine($"Время выполнения методом сортировки слияния: {stopwatch_merge.ElapsedMilliseconds} мс\n Количество перестановок: {swap_merge}");

            Stopwatch stopwatch_cocktail = Stopwatch.StartNew();
            cocktail.CocktailSort(array_c);
            stopwatch_cocktail.Stop();
            ulong swap_cocktail = cocktail.swap_cocktail();
            Console.WriteLine($"Время выполнения методом шейкерной сортировки: {stopwatch_merge.ElapsedMilliseconds} мс\n Количество перестановок: {swap_cocktail}");

            Stopwatch stopwatch_quick = Stopwatch.StartNew();
            quick.QuickSort(array_q);
            stopwatch_cocktail.Stop();
            ulong swap_quick = quick.swap_quick();
            Console.WriteLine($"Время выполнения методом быстрой сортировки: {stopwatch_quick.ElapsedMilliseconds} мс\n Количество перестановок: {swap_quick}");

            Console.ReadLine();
            Console.ReadKey();
        }

    }
}
