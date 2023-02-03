// Урок 7. Двумерные массивы
// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// Console.Write("Ведите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Ведите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);

// double[ , ] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// double[ , ] GetArray (int m, int n, int min, int max)
// {
//           double[ , ] result = new double[m, n];
//           for (int i = 0; i < m; i++)
//           {
//                     for (int j = 0; j < n; j++)
//                     {
//                               result[i, j] = new Random().NextDouble()*(max-min);
//                     }
//           }
//           return result;
// }

// void PrintArray(double[ , ] inArray)
// {
//           for (int i = 0; i < inArray.GetLength(0); i++)
//           {
//                     for (int j = 0; j < inArray.GetLength(1); j++)
//                     {
//                               Console.Write($"{inArray[i, j]:f1}");
//                     }
//                     Console.WriteLine();
//           }
// }


// Задача 50. Напишите программу, которая на вход принимает число, 
// и проверяет есть ли такое число в двумерном массиве, 
// а также возвращает сообщение о том, что оно найдено или же указание,
// что такого элемента нет.

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// Console.Write("Введите значение элемента: ");
// int element = int.Parse(Console.ReadLine()!);
// if (FindElement(array, element))
// {
//                     Console.WriteLine("Элемент найден");
// }
// else
// {
//                     Console.WriteLine("Элемент не найден");
// }

// int[,] GetArray(int m, int n, int min, int max)
// {
//                     int[,] result = new int[m, n];
//                     for (int i = 0; i < m; i++)
//                     {
//                                         for (int j = 0; j < n; j++)
//                                         {
//                                                             result[i, j] = new Random().Next(min, max + 1);
//                                         }
//                     }
//                     return result;
// }

// void PrintArray(int[,] inArray)
// {
//                     for (int i = 0; i < inArray.GetLength(0); i++)
//                     {
//                                         for (int j = 0; j < inArray.GetLength(1); j++)
//                                         {
//                                                             Console.Write($"{inArray[i, j]}");
//                                         }
//                                         Console.WriteLine();
//                     }
// }

// bool FindElement(int[,] array, int el)
// {
//                     for (int i = 0; i < array.GetLength(0); i++)
//                     {
//                                         for (int j = 0; j < array.GetLength(0); j++)
//                                         {
//                                                             if (array[i, j] == el) return true;
//                                         }
//                     }
//                     return false;
// }

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine()!);

int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);

for (int j = 0; j < numbers.GetLength(1); j++)
{
          double avarage = 0;
          for (int i = 0; i < numbers.GetLength(0); i++)
          {
                    avarage = (avarage + numbers[i, j]);
          }
          avarage = avarage / n;
          Console.Write($"{avarage + "; ":f1}");
} 
// Console.Write($"{inArray[i, j]:f1}");
Console.WriteLine();
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
          for (int i = 0; i < array.GetLength(0); i++)
          {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                              array[i, j] = new Random().Next(0, 10);
                    }
          }
}

void PrintArray(int[,] array)
{
          for (int i = 0; i < array.GetLength(0); i++)
          {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                              Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine("");
          }
}
