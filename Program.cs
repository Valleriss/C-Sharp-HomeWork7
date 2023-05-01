/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */


int[,] array = Generate2DArray(3, 4);
Print2dArray(array);
double[] avarage = FindAverageColumnTo2dArray(array);
Console.Write($"Среднее арифметическое каждого столбца: ");
PrintArray(avarage);


double[] FindAverageColumnTo2dArray(int[,] array) // Выводит массив средних арифметических каждого столбца двумерного массива
{
    double[] avarageArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        double avarage = sum / (array.GetLength(1) - 1);
        avarageArray[j] = Math.Round(avarage, 2);
    }
    return avarageArray;
}

void Print2dArray(int[,] array) // Печатает двумерный массив
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("|");
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"<{array[i, j]}>");
            Console.Write(" ");
        }
        Console.Write("|");
        Console.WriteLine();
    }
}

int[,] Generate2DArray(int m, int n) // Создает двумерный массив
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(10, 20);
        }
    }

    return array;
}

void PrintArray(double[] array) // Печатает указанный массив
{
    Console.WriteLine($"[{string.Join("; ", array)}]");
}