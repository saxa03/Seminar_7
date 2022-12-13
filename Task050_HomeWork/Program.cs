//  Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
//  значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  17 -> такого числа в массиве нет
using System;
using static System.Console;

Clear();
WriteLine("введите номер строки");
int lines = int.Parse( ReadLine());
WriteLine("введите номер столбца");
int columns =  int.Parse( ReadLine());
int[,] matrix = new int[5, 8];
FillArray(matrix);
PrintArray(matrix);

if (lines > matrix.GetLength(0) || columns > matrix.GetLength(1))
{
    WriteLine("такого элемента нет");
}
else
{
    WriteLine($"значение элемента {lines} строки и {columns} столбца равно {matrix[lines-1,columns-1]}");
}

// Заполнение массива рандомными числами 
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

//  Функция вывода 
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
