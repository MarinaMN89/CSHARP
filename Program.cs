// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double[] array = new double[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round(new Random().NextDouble(), 2);

    Console.Write($"{array[i]} ");
}
double max = array[0];
double min = array[0];
Console.WriteLine("");
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine(max);
Console.WriteLine(min);
Console.WriteLine($"Разница макс и мин = {Math.Round((max - min), 2)}");