﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// Console.WriteLine("Введите размер массива m x n и диапазон случайных значений:");
// Console.WriteLine("Укажите количество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Укажите количество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Укажите дипазон случайных значений от 1 до ");
// int range = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];

// CreateArray(array);
// PrintArray(array);
// DecreasingArrayLines(array);
// PrintArray(array);

// void CreateArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, range);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]}  ");
//         }
//         Console.WriteLine("");
//     }
// }

// void DecreasingArrayLines(int[,] array)
// {
//     Console.WriteLine("");
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }




