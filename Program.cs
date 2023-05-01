/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */

Console.Write($"Введите кол-во строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write($"Введите кол-во столбцов: ");
int n = int.Parse(Console.ReadLine());

double[,] array = Generate2DArray(m, n);
PrintArray(array);

void PrintArray(double[,] array) // Распечатывает двумерный массив
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"<{array[i, j]}>");
            Console.Write(" ");
        }

        Console.WriteLine();
    }
}

double[,] Generate2DArray(int m, int n) // Собирает двумерный массив по данным пользователя
{
    double[,] array = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"Введите значение {j + 1}го элемента {i + 1}й строки: ");
            double value = double.Parse(Console.ReadLine());
            array[i, j] = value;
        }
    }

    return array;
}