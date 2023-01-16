// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Write("Введите число: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);
    Console.Write($"{array[i]} ");
}

System.Console.WriteLine();

int N = 0;

for (int i=0; i<M;i++)
{
    if (array[i]>0)    N = N + 1;
}
Console.WriteLine(N);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// System.Console.WriteLine("Введите b1");
// double b1 = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine("Введите k1");
// double k1 = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine("Введите b2");
// double b2 = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine("Введите k2");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double x = (b2-b1)/(k1-k2);
// double y = k2*(b2-b1)/(k1-k2) + b2;

// Console.WriteLine($"({x}; {y})");

