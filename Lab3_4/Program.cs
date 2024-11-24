using System;

class Program
{
    static void Main()
    {
        // Инициализация двумерных массивов 3x3
        int[,] array1 = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int[,] array2 = {
            { 9, 8, 7 },
            { 6, 5, 4 },
            { 3, 2, 1 }
        };

        // Сложение массивов
        int[,] sumResult;
        double sumAverage;
        sumResult = AddArrays(array1, array2, out sumAverage);

        Console.WriteLine("Сумма массивов:");
        PrintArray(sumResult);
        Console.WriteLine($"Среднее значение всех элементов: {sumAverage}");

        // Вычитание массивов
        int[,] subtractResult;
        double subtractAverage;
        subtractResult = SubtractArrays(array1, array2, out subtractAverage);

        Console.WriteLine("\nРазность массивов:");
        PrintArray(subtractResult);
        Console.WriteLine($"Среднее значение всех элементов: {subtractAverage}");
    }

    static int[,] AddArrays(int[,] array1, int[,] array2, out double average)
    {
        int[,] result = new int[3, 3];
        int totalElements = 0;
        int sum = 0;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                result[i, j] = array1[i, j] + array2[i, j];
                sum += result[i, j];
                totalElements++;
            }
        }

        average = (double)sum / totalElements;
        return result;
    }

    static int[,] SubtractArrays(int[,] array1, int[,] array2, out double average)
    {
        int[,] result = new int[3, 3];
        int totalElements = 0;
        int sum = 0;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                result[i, j] = array1[i, j] - array2[i, j];
                sum += result[i, j];
                totalElements++;
            }
        }

        average = (double)sum / totalElements;
        return result;
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}