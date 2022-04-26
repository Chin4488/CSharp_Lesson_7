// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
Console.WriteLine("Введите количество строк в заданном массиве");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в заданном массиве");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m,n];
// заполнение массива
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
    array[i, j] = new Random().NextDouble();
    }
}
// печать массива
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
    Console.Write($" {array[i, j]} ");
    }
    Console.WriteLine();
}