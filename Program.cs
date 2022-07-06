using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    internal class Program
    {
        static void FillArray(int[] array, int min, int max)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(min, max);
            }
        }

        static void WriteArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static int QuantityPositive(int[] array)
        {
            int quantity = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    quantity++;
                }
            }
            return quantity;
        }

        static int RandomNumbers(int numberElements, int min, int max)
        {
            int[] randomNumbers = new int[numberElements];
            int sumElements = 0;
            Console.Write("Получившийся массив: ");

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = new Random().Next(min, max);

                Console.Write(randomNumbers[i] + " ");

                if (i % 2 != 1)
                {
                    sumElements = sumElements + randomNumbers[i];
                }
            }
            return sumElements;
        }

        static void Main(string[] args)
        {
            //Количество чётных чисел в массиве
            int[] numbers = new int[10];

        

            FillArray(numbers, 100, 1000);
            WriteArray(numbers);
            Console.WriteLine();

            int quantity = QuantityPositive(numbers);
            Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");

          
            ///Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
            Console.Write($"Введи количество элементов массива: ");
            int numberElements = Convert.ToInt32(Console.ReadLine());

            int randomNumbers = RandomNumbers(numberElements, 1, 10);

            Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {randomNumbers}");

            ///Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
            double[] arrayRealNumbers = new double[10];
            for (int i = 0; i < arrayRealNumbers.Length; i++)
            {
                arrayRealNumbers[i] = new Random().Next(1, 10);
                Console.Write(arrayRealNumbers[i] + " ");
            }

            double maxNumber = arrayRealNumbers[0];
            double minNumber = arrayRealNumbers[0];

            for (int i = 1; i < arrayRealNumbers.Length; i++)
            {
                if (maxNumber < arrayRealNumbers[i])
                {
                    maxNumber = arrayRealNumbers[i];
                }
                if (minNumber > arrayRealNumbers[i])
                {
                    minNumber = arrayRealNumbers[i];
                }
            }

            double decision = maxNumber - minNumber;

            Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");

        }
    }
}
