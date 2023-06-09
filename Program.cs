﻿// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

void InitArray()
{
    int[,] array = FillArray();
    RandomArray(array);
    PrintArray(array);
    Console.WriteLine();
    SumPow(array);
}

int[,] FillArray()
{
    Console.Write("Enter m: ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Enter n: ");
    int n = int.Parse(Console.ReadLine());
    return new int[m,n];
}

void RandomArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
       {
        array[i,j] = new Random().Next(1,9);
       }
    }
}

void PrintArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
       {
            Console.Write($"{array[i,j]} ");
       }
        Console.WriteLine();
    }  
}

void SumPow(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        Console.WriteLine($"{sum}");
    }
}



InitArray();