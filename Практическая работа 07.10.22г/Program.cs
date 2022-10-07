using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_07._10._22г
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начальный диапозон: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Введите конечный диапозон: ");
            int numbertwo = int.Parse(Console.ReadLine());
            int[] array = new int[10];
            foreach (var item in List(array, number, numbertwo))
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        public static int[] List(int[] array, int number, int numbertwo)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(number, numbertwo);
            }
            return array;
        }
    }
}
