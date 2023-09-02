// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// int[,] matrix = new int[4,6];

// void NewMass(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(0,10);
//         }
//     }
// }

// void StMass(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (j == 0)
//             {
//                 System.Console.Write("[");
//             }
//             System.Console.Write(array[i,j]);
//             if (j == array.GetLength(1) - 1)
//             {
//                 System.Console.Write("]");
//             }
//             else
//             {
//                 System.Console.Write("; ");
//             }
//         }
//         System.Console.WriteLine();
//     }
// }
// void SortArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1)-1;k++)
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
// NewMass(matrix);
// StMass(matrix);
// SortArray(matrix);
// System.Console.WriteLine();
// StMass(matrix);


// Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка


// int[,] matrix = new int[6,6];

// void Mass(int[,]array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random(). Next(0,10);
//         }
//     }
// }
// void Mass1(int[,]array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i,j]+ " ");
//         }
//         System.Console.WriteLine();
//     }
// }
// void Mass2(int[,]array)
// {
//     int minline = 0;
//     int min = int.MaxValue;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         // int min = int.MaxValue;
//         for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 sum+= array[i,j];
//             }
//         System.Console.WriteLine($"Сумма строки {i + 1} = {sum}");
//         if (sum<min)
//         {    
//             min = sum;
//             minline = i;
//         }
//     }
//     System.Console.WriteLine($"Строка с наименьшей суммой {minline + 1}");
// }

// Mass(matrix);
// Mass1(matrix);
// Mass2(matrix);



// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// int[,,] matrix = new int[3,3,10];

// bool west = true;
// void Mass(int[,,]array)
// {
//     int element = 0;
//     int a = 0;
//     int b = 0;
//     int c = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 west = true;
//                 while (west)
//                 {
                    
//                     array[i,j,k] = new Random().Next(10,100);
//                     element = array[i,j,k];
//                     a = i; b = j; c = k;
//                     Mass3(array,element,a,b,c);
//                 }
//             }
//         }
//     }
// }
// bool Mass3(int[,,]array, int el, int a1, int b1, int c1)
// {
//     for (int i = a1 - 1; i > 0; i--)
//     {
//         for (int j = b1 - 1; j > 0; j--)
//         {
//             for (int k = c1 - 1; k > 0; k--)
//             {
                
//                 if (el == array[i,j,k])
//                 {
//                     west = true;
//                     return west;
//                 }
//             }
//         }
//     }
//     west = false;
//     return west;
// }
// void Mass2(int[,,]array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i,j,k]}({i} {j} {k}) ");
                
//             }
//             System.Console.WriteLine();
//         }
//         System.Console.WriteLine();
//     }
// }

// Mass(matrix);
// Mass2(matrix);