// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
// Console.WriteLine("Укажите количество строк  в первой матрице ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Укажите количество столбцов первой матрицы (одновременно является числом строк второй)  ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Укажите количество столбцов второй матрицы ");
// int p = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Укажите дипазон случайных значений от 1 до ");
// int range = Convert.ToInt32(Console.ReadLine());
// int[,] firstMartrix = new int[m, n];

// CreateArray(firstMartrix);
// Console.WriteLine("Первая матрица:");
// PrintArray(firstMartrix);

// int[,] secomdMartrix = new int[n, p];
// CreateArray(secomdMartrix);
// Console.WriteLine("Вторая матрица:");
// PrintArray(secomdMartrix);

// int[,] resultMatrix = new int[m,p];

// MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
// Console.WriteLine("Произведение первой и второй матриц:");
// PrintArray(resultMatrix);

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void PrintArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
// {
//   for (int i = 0; i < resultMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < firstMartrix.GetLength(1); k++)
//       {
//         sum += firstMartrix[i,k] * secomdMartrix[k,j];
//       }
//       resultMatrix[i,j] = sum;
//     }
//   }
// }




