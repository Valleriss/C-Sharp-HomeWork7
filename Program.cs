/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1, 7 -> такого числа в массиве нет */


Console.Write("Введите индекс строки: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите индекс столбца: ");
int n = int.Parse(Console.ReadLine());

int[,] array = Generate2DArray(3, 4);
PrintArray(array);
CheckPresenceElement(array, m, n);


void CheckPresenceElement(int[,] array, int m, int n) // проверяет существует ли значение введенного элемента и выводит его если существует
{
    if (m > 0 && n > 0)
    {
        if (m < array.GetLength(0) && n < array.GetLength(1))
        {
            Console.WriteLine($"Значение = {array[m, n]}");
        }
        else
        {
            Console.WriteLine("Такого элемента нет");
        }
    }
    else
    {
        Console.WriteLine("Такого элемента нет");
    }

}

void PrintArray(int[,] array) // Печатает двумерный массив
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

int[,] Generate2DArray(int m, int n) // Генерирует рандомный двумерный массив 
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(1, 15);
        }
    }

    return array;
}