/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9    */

 
Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
PrintArray(GetArray(rows, columns, -10, 10));


double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] FillArrayRandom = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        { FillArrayRandom[i, j] = Math.Round((new Random().NextDouble() * (maxValue - minValue) + minValue),1); }
    }
    return FillArrayRandom;
}

void PrintArray(double[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write(Array[i, j] + " ");
        }
        Console.WriteLine("");  
    }
}         

/*Задача 50. Напишите программу, которая на вход принимает число, и проверяет есть ли такое число в двумерном массиве, 
а также возвращает сообщение о том, что оно найдено или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет  */





