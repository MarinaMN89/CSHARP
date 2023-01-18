// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите число m");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число n");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] array = new double[m, n];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//         array[i, j] = Math.Round ((new Random().Next(-50, 50) + new Random().NextDouble()), 1);
//         Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine("");
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// Console.WriteLine("Введите число  m");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число  n");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matr = new int[m, n];

// for (int i = 0; i < matr.GetLength(0); i++)
// {
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//         matr[i, j] = new Random().Next(0, 50);
//         Console.Write($"{matr[i, j]} ");
//     }
//     Console.WriteLine("");
// }
// Console.WriteLine("Введите  позицию элемента x");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите позицию элемента y");
// int y = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i < matr.GetLength(0); i++)
// {
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//         if (i == x && j == y)
//         {
//             Console.WriteLine($"Значение элемента = {matr[i, j]}");
//         }

//         else 
//         {
//             Console.WriteLine("Такого элемента нет");
//         }

//     }
// }

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.WriteLine("Введите число  m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число  n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matr = new int[m, n];

for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i, j] = new Random().Next(0, 10);
        Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine("");
}

for (int j = 0; j < matr.GetLength(1); j++)
{
    double avg = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        avg = avg + matr[i, j];
    }

    avg = Math.Round(avg / m, 2);
    Console.WriteLine($"{avg} ");
}

