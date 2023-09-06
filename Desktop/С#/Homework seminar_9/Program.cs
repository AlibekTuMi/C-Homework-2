// Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5->"5,4,3,2,1"
// N = 8->"8,7,6,5,4,3,2,1"


// System.Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());

// int startNum = 1;
 
// Console.WriteLine(PrintNumbers(num,startNum));

// string PrintNumbers(int end, int start)
// {
//     if (end == start)
//     {
//         return end.ToString();
//     }
//     return (end + " " + PrintNumbers(end - 1,start)); 
// }



// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30


// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите первое число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1>num2)
// {
//     Console.WriteLine("Первое число должно быть меньше второго!");
// }

// System.Console.WriteLine(PrintNum(num1,num2));

// string PrintNum(int num1,int num2)
// {
//     if (num1 == num2)
//     {
//         return num1.ToString();
//     }
//     return (num1 + " " + PrintNum(num1 + 1, num2));
// }
// int sum = 0;
// while (num1<=num2)
// {
//     sum+=num1;
//     num1++;
// }
// System.Console.WriteLine($"Сумма чисел массива равна {sum}");


// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два 
// неотрицательных числа m и n.
// m = 2, n = 3->A(m,n) = 9
// m = 3, n = 2->A(m,n) = 29

Console.WriteLine("Введите число m");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число n");
int m = Convert.ToInt32(Console.ReadLine());

A(m, n);
            
static int A(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    } 
    else if (m != 0 && n == 0)
    {
        return A(m - 1, 1);
    } 
    else if (m != 0 && n != 0)
    {
        return A(m - 1, A(m, n - 1));
    } 
    return A(m,n);
}
Console.WriteLine(A(m,n));

Последняя задача сложная на понимание. Насколько я понял, это связано с 
записью и сохранением информации, и определением, какое количество памяти нужно
для определенного объёма.





