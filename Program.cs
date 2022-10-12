// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] array = GetArray(3, 4, 0, 9);
// PrintArray(array);
// Console.WriteLine();

// SortLineElements(array);
// PrintArray(array);

// void SortLineElements(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if (array[i, k] < array[i, k + 1])
//         {
//           int temp = array[i, k + 1];
//           array[i, k + 1] = array[i, k];
//           array[i, k] = temp;
//         }
//       }
//     }
//   }
// }



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка


// int[,] array = GetArray(4, 4, 0, 9);
// PrintArray(array);

// int MinRowSumm = 37;
// int MinRowIndex = 0;

// for (int i = 0; i < 4; i++)
// {
//     int RowSumm = 0;

//     for (int j = 0; j < 4; j++)
//     {
//         RowSumm += array[i, j];
//     }
//     if (RowSumm < MinRowSumm)
//     {
//         MinRowSumm = RowSumm;
//         MinRowIndex = i;
//     }
// }

// Console.Write($"Номер строки с наименьшей суммой элементов: {MinRowIndex + 1}");




// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] array = GetArray(2, 2, 0, 9);
PrintArray(array);
Console.WriteLine();


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)





// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



// Рекомендовано решить(задача с семинара)

// Отсортировать нечетные столбцы массива по возрастанию. Вывести массив изначальный и массив с отсортированными нечетными столбцами

// Сдайте задание до: 17 окт., 20:00 MSK




// Console.WriteLine("Введите количество строк (m): ");
// int m = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите количество столбцов (n): ");
// int n = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(m, n, 0, 99);
// PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}