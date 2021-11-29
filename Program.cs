using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа расчитывает среднеарифметическое элементов одномерного массива состоящего из 7-ми элементов");
            // Ввод данных
            Console.WriteLine("Введите элементы массива");
            float[] array;
            int n = 7;
            array = new float[n];
            float S = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("array[{0}]=", i + 1);
                array[i] = float.Parse(Console.ReadLine());
            }
            Console.Write("Массив =>");
            for (int i = 0; i < 7; i++)
            {
                Console.Write("{0,3}", array[i]);
            }
            Console.WriteLine();
            // Решение
            for (int i = 0; i < n; i++)
            {
                S += array[i];
            }
            Console.WriteLine("Среднеарифметическое массива = {0:f2}", S / n);
            Console.ReadKey();
        }
    }
}