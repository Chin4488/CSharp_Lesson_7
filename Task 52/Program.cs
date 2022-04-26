// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("Введите количество строк в заданном массиве");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в заданном массиве");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m,n];
// заполнение массива и печать
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++)
    {
    array[i, j] = new Random().Next(0,11);
    Console.Write(array[i,j]+" ");
    }
}
// подсчёт среднего арифмитического в столбцах
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца: ");
double srednearif = 0;
for (int j = 0; j < array.GetLength(1); j++)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        srednearif = srednearif + array[i, j];
    }
    Console.Write($"{Math.Round(srednearif/m, 1)}, ");
    srednearif = 0;
}