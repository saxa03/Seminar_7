//052: Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
using System;
using static System.Console;


WriteLine("введите количество строк");
int lines = int.Parse(ReadLine());
WriteLine("введите количество столбцов");
int columns = int.Parse(ReadLine());

int[,] matrix = new int[lines, columns];
FillArray(matrix);
PrintArray(matrix);

for (int j = 0; j < matrix.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        avarage = (avarage + matrix[i, j]);
    }
    avarage = avarage / lines;
    Write($"среднеарифмет = {avarage:f3}  ");
    
}
WriteLine();

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
            for (int j = 0; j < matr.GetLength(1); j++)
        {
            Write($"{matr[i, j]}");
        }
            WriteLine();
    }
}
