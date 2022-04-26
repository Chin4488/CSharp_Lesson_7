// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба
// индекса нечётные, и замените эти элементы на их квадраты.
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
Console.WriteLine();
// изменение массива и печать
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i % 2 == 1 && j % 2 == 1)
        {
        Console.Write(array[i,j] * array[i,j] + " ");
        }
        else 
            {
            Console.Write(array[i,j]+" ");
            }
    }
}