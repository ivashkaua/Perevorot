using System;

namespace Perevorot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: \t");
            int ArrNumber = int.Parse(Console.ReadLine());
            int[] array = new int[ArrNumber];

            for (int l = 0; l < ArrNumber; l++)
            {
                Console.Write($"\nВведите число с индексом {l} \t");
                array[l] = int.Parse(Console.ReadLine());
            }

            Console.Write($"\nТаким образом, массив выглядит следующим образом:\n\n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.Write($"\nИ теперь наоборот:\n\n");
            for (int i = array.Length-1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
