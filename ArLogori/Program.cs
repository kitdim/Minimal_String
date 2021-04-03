using System;

namespace ArLogori
{
    class Program
    {
        /// <summary>
        /// заполнение массива чз клавиатуру 
        /// </summary>
        /// <param name="arr"></param>
        static void Fill(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
                Console.Clear();
            }
        }

        /// <summary>
        /// Вывод массива
        /// </summary>
        /// <param name="args"></param>
        static void Input(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        /// <summary>
        /// Проверка на арифметическую последовательность
        /// </summary>
        /// <param name="args"></param>
        static void Arimf(double[] arr)
        {
            var d = arr[1] - arr[0];

            if (arr[3] == arr[2] + d && arr[3] == arr[0] + 3 * d) Console.WriteLine("Yes");
            else Console.WriteLine("Not");
        }

        /// <summary>
        /// Проверка на геометрическую последовательность
        /// </summary>
        /// <param name="args"></param>
        static void Geometr(double[] arr)
        {
            var q = arr[1] / arr[0];

            if (arr[3] == arr[0] * Math.Pow(q, 3) && arr[2] == arr[1] * q) 
                Console.WriteLine("Yes");
            else
                Console.WriteLine("Not");

        }
        static void Main(string[] args)
        {
            double[] arifm = new double[4];
            Fill(arifm); Input(arifm);

            Console.Write("\nIs this an arithmetic sequence? "); Arimf(arifm);
            Console.Write("Is this a geometric sequence? "); Geometr(arifm);
            Console.ReadKey();
        }
    }
}
