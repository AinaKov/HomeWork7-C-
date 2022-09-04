/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

void FillArray(int[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            tab[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] tab)
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
void AverageArray(int[,] tab)
{
    double sum = 0;
    for (int j = 0; j < tab.GetLength(1); j++)
    {
        for (int i = 0; i < tab.GetLength(0); i++)
        {
            sum = sum + tab[i, j];
        }
        Console.Write(Math.Round(sum / tab.GetLength(0),1) + "; ");
        sum = 0;
    }
}

int[,] table = new int[4, 5];
FillArray(table);
PrintArray(table);
AverageArray(table);