using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Array
{
    internal class create
    {
        public static int[] crt_m_array(int dimensionality)
        {
            Random random = new Random();
            int[] array = new int[dimensionality];

            // Заполняем массив случайными числами
            for (int i = 0; i < dimensionality; i++)
            {
                array[i] = random.Next(0, 1000);
            }

            // Выводим исходный массив
            Console.WriteLine($"Исходный массив:  {dimensionality} элементов");
            StreamWriter main_array = new StreamWriter("C:\\Users\\vittm\\source\\repos\\Console_sort\\main_array.txt");
            for (int i = 0; i < dimensionality; i++)
            {
                main_array.Write(array[i] + " ");
            }
            main_array.Close();

            return array;
        }

    }
}
