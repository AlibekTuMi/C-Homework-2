// Напишите программу, которая выводит случайное число из
// отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12 -> 2
// 85 -> 8

int num = new Random().Next(10, 99);
Console.WriteLine(num);

int num1 = num / 10;
int num2 = num % 10;

if(num1>num2)
{
    Console.WriteLine("Число" + num1+ "больше чем"); // канкатинация
}
else if(num1==num2)
{
    Console.WriteLine("Числа равны");
}
else
{
    Console.WriteLine($"Число {num2} больше чем");  // интерполяция
}
