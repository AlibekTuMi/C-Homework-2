﻿// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в 
// натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите возводимое число : ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число, в которое хотите возвести : ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// double s =Math.Pow((num1), num2);

// System.Console.WriteLine(s);



// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());

int GetSumNum()
{
    int sum = 0; 
    while (num > 0) 
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

Console.WriteLine(GetSumNum());







