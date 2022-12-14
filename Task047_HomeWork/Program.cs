//47 заполнение случайными вещественными числами
using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int lines =  Convert.ToInt32(ReadLine());

Write("Введите количество столбцов массива: ");
int columns =  Convert.ToInt32(ReadLine());

double[,] matrix = new double[lines, columns];
FillArray(matrix);
PrintArray(matrix);

// Заполнение массива рандомными вещественными числами
void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Convert.ToDouble (new Random().Next(-50, 50));
        }
    }
}


//  Функция вывода двумерного массива в терминал
void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Write($"{matr[i, j]} ");
        }
        WriteLine();
    }    
}
