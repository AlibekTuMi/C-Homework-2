﻿// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9].
// Найдите суумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.


// int [] array = new int[12];
// int sumposNum = 0;
// int sumNegNum = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-9,10);
//     Console.Write(array[i]+" ");

//     if (array[i]>0)
//     {
//         sumposNum+=array[i];
//     }
//     else
//     {
//         sumNegNum+=array[i];
//     }
// }
// Console.WriteLine();
// System.Console.WriteLine($"Сумма положительных = {sumposNum}, отрицательных = {sumNegNum}");


// Напишите программу замена элементов масиива: положительные элементы замените на
// соответствующие отрицательные и наоборот.
// [-4,-8,8,2]->[4,8,-8,-2]

// int [] array = new int[4];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-9,10);
//     Console.Write(array[i]+" ");

//     array[i] = array[i] * -1;
// }
// System.Console.WriteLine();

// for (int j = 0; j < array.Length; j++)
// {

//     Console.Write(array[j]+" ");

// }


// Задайте маассив. Напишите программу, которая определяет, присутствует ли заданное число
// в массиве.
// 4; массив [6,7,19,345,3] -> нет
// -3; массив [6,7,19,345,-3] -> да


// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// bool isFind = false;

// int [] array = new int[5];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0,5);
//     Console.Write(array[i]+" ");
//     if (num == array[i])
//     {
//         isFind = true;
//     } 
// }
// if (isFind == true)
// {
//     System.Console.WriteLine("Да");
// }
// else
// {
//     System.Console.WriteLine("Нет");
// }


// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].
// [5,18,123,6,2]->1
// [1,2,3,6,2]->0
// [10,11,12,13,14]->5

// int[] array = new int[50];
// int connt = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 123);
//     Console.Write(array[i] + " ");

//     if (array[i] > 9 && array[i] < 100)
//     {
//         connt++;
//     }
// }
// System.Console.WriteLine();
// System.Console.WriteLine(connt++);

// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// второй и предпоследний элемент и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5]->5 8 3
// [6 7 3 6]->36 21

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int[] array1 = new int[num];
int[] array2 = new int[array1.Length/2 +array1.Length%2];

for (int i = 0; i < array1.Length; i++)
{
    array1[i] = new Random().Next(0,9);
    System.Console.Write(array1[i]+" ");
}

for (int i = 0; i < array2.Length; i++)
{
    array2[i] = array1[i] * array1[array1.Length - 1 - i];
    if (array1.Length - 1 - i == i)
    {
        array2[i] = array1[i];
    }
}
System.Console.WriteLine();
for (int i = 0; i < array2.Length; i++)
{
    System.Console.Write(array2[i]+" ");
}



