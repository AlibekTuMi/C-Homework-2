﻿// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3



// Console.WriteLine("Введите число");
// int number1= Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine("Введите число");
// int number2= Convert.ToInt32 (Console.ReadLine());

// int max, min;

// if (number1 > number2)
// {
//     max = number1;
//     min = number2;
// }
// else 
// {
//     max = number2;
//     min = number1;
// }

//Console.WriteLine(max + " больше " + min);

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите число");
// int number1= Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine("Введите число");
// int number2= Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine("Введите число");
// int number3= Convert.ToInt32 (Console.ReadLine());

// int max = number1;
// int cou = 0;
// while(cou < 2)
// {
//     if (number2 > max)
//     {
//     max = number2;
//     }
//     else if(number3 > max)
//     {
//     max = number3;
//     }
//     cou++;
// }

// Console.WriteLine(max);


// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число");
int number= Convert.ToInt32 (Console.ReadLine());

if (number% 2 == 0)
{
    Console.WriteLine("Является чётным");
}
else
{
    Console.WriteLine("Является нечётным");
}