using System.Security.Cryptography.X509Certificates;

namespace PerfectNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Поиск совершенного числа\n");
            int x = 1;
            while (true)
            {
                //int number = SummDivider(SearchDividers(x));
                int number = SearchDividersV2(x);
                if (number == x)
                {
                    Console.WriteLine(number);
                }
                x++;
            }
        }

        /// <summary>
        /// Поиск списка делителей числа
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static List<int> SearchDividers(int number)
        {
            List<int> dividers = new List<int>();

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    dividers.Add(i);
                }
            }

            return dividers;
        }

        /// <summary>
        /// Суммирование делителей числа
        /// </summary>
        /// <param name="dividers"></param>
        /// <returns></returns>
        private static int SummDivider(List<int> dividers)
        {
            int number = 0;
            foreach (int i in dividers)
            {
                number += i;
            }
            return number;
        }

        /// <summary>
        /// Быстрое решение
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static int SearchDividersV2(int number)
        {
            int summ = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    summ += i;
                }
            }

            return summ;
        }
    }
}