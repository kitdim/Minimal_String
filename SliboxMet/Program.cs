using System;

namespace SliboxMet
{
    class Program
    {
        /// <summary>
        /// Заполнение массива с вводом через клавиатуру
        /// </summary>
        /// <param name="arr"></param>
        static void Fill(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
                Console.Clear();
            }
        }

        /// <summary>
        /// Вывод массива
        /// </summary>
        /// <param name="args"></param>
        static void Input(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        /// <summary>
        /// Вывод минимальной строки 
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static string InputString(string[] arr)
        {
            string letter = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (letter.Length>arr[i].Length)
                {
                    letter = arr[i];                    
                }
            }
            return letter;
        }

        /// <summary>
        /// Вывод максимальной строки
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static string InputArray(string[] arr)
        {
            string letter = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (letter.Length < arr[i].Length)
                {
                    letter = arr[i];
                }
            }
            return letter;
        }

        /// <summary>
        /// Пауза
        /// </summary>
        /// <param name="args"></param>
        static void Delay()
        {
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            string[] array = new string[5];

            Fill(array); Console.Clear();
            Input(array);


            Console.WriteLine($"\nМинимальная последовательность = {InputString(array)}");
            Console.Write($"Максимальная последовательность = {InputArray(array)}");
            Delay();
        }
    }
}
