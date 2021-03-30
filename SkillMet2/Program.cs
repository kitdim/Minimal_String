using System;

namespace SkillMet2
{
    class Program
    {
        /// <summary>
        /// Метод для очистки повторяющихся значений
        /// </summary>
        /// <param name="str"></param>
        static void Rep(string str)
        {
            int i = 0;
            while (true)
            {
                var tmp = str[i].ToString();
                str = str.Replace(tmp, "");
                str = str.Insert(i, tmp);
                i++;
                if (str.Length - 1 < i) break;
            }
            Console.WriteLine(str);
        }
        static void Main()
        {
            string str = Console.ReadLine();
            Rep(str);
            Console.ReadKey();
        }
    }
}
