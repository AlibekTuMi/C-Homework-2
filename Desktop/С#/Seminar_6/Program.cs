// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45-> 101101
// 3-> 11
// 2->10


// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// string result = "";

// while (num>0)
// {
//     result = num%2 + result;
//     num = num /2;
// }
// System.Console.WriteLine(result);



// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать 
// треугольник со сторонами такой длины.

// System.Console.WriteLine("Введите размеры сторон треугольника на проверку");
// Console.WriteLine("Первое число");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Второе число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Третье число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num < num1 + num2 && num1 < num + num2 && num2 < num + num1)
// {
//     System.Console.WriteLine();
//     System.Console.WriteLine("Да)");
// }
// else
// {
//     System.Console.WriteLine();
//     System.Console.WriteLine("Нет!");
// }


// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа : 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


// System.Console.WriteLine("Введите количество чисел Фибоначчи");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num>0)
// {   
//     int firstNum = 0;
//     int secondNum = 1;

//     System.Console.WriteLine();
//     System.Console.WriteLine(firstNum);
//     System.Console.WriteLine(secondNum);

//     for (int i = 2; i < num; i++)
//     {
//         int nextNum = firstNum + secondNum;
//         System.Console.WriteLine(nextNum);
//         firstNum = secondNum ;
//         secondNum = nextNum ;
//     }
//     System.Console.WriteLine();
// }
// else
// {
//     System.Console.WriteLine("Неверное число");
// }



// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на превом месте, а первый на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


// int[] array = new int[] {3,2,4,8,7,0};

// void ReversArray()
// {
//     for (int i = 0; i < array.Length/2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
// }
// void PrintArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i]+ " ");
//     }
// }
// ReversArray();
// PrintArray();



// Напишите программу, которая будет создавать копию заданного массива с помощью
// поэлементного копирования.


// int[] array = new int[] {3,2,4,8,7,0};
// int[] copyArray = new int[array.Length];

// void CopyArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         copyArray[i] = array[i];
//     }
// }
// void PrintCopyArray()
// {
//     for (int i = 0; i < copyArray.Length; i++)
//     {
//         System.Console.Write(copyArray[i]+ " ");
//     }
// }
// CopyArray();
// PrintCopyArray();



