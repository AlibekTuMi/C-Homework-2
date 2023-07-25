// Напишите программу, которая выводит случайное число из
// отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12 -> 2
// 85 -> 8

// int num = new Random().Next(10, 99);
// Console.WriteLine(num);

// int num1 = num / 10;
// int num2 = num % 10;

// if(num1>num2)
// {
//     Console.WriteLine("Число" + num1+ "больше чем"); // канкатинация
// }
// else if(num1==num2)
// {
//     Console.WriteLine("Числа равны");
// }
// else
// {
//     Console.WriteLine($"Число {num2} больше чем");  // интерполяция
// }


// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// 456->46
// 782->72
// 918->98

// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);

// int num1 = num / 100;
// int num2 = num % 10;
// int result = num1 * 10 + num2;

// Console.WriteLine(result);


// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число 
// кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.Readline());

// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.Readline());

// if(num % num1 == 0)
// {
//     Console.WriteLine("Числа кратные");
// }
// else
// {
//     Console.WriteLine("Числа не кратные, остаток равен" + num % num1")

// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

// 14->нет
// 46->нет
// 161->да

// && - все условия должны выполниться
// || - хотя бы одно

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if ((num % 7 == 0) || (num % 23 ==0))
{
    Console.WriteLine("Кратные");
}
else
{
    Console.WriteLine("Не кратные");
}