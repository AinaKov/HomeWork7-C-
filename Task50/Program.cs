/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

void FillArray(double[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {

            tab[i, j] = new Random().Next(-100, 100);
        }
    }
}

void PrintArray(double[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            Console.Write($"{tab[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[,] table = new double[10, 10];
FillArray(table);
PrintArray(table);
Console.Write("Введите строку: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m <= table.GetLength(0) & n <= table.GetLength(1))
{
    Console.WriteLine(table[m - 1, n - 1]);
}
Console.WriteLine("такого числа в массиве нет");


