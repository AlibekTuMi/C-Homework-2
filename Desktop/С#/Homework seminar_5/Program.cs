// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] array = new int[10];
// int count = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100, 1000);
//     Console.Write(array[i] + " ");
//     if (array[i] / 2 * 2 < array[i])
//     {
//         count = count + 0;
//     }
//     else
//     {
//         count++;        
//     }

// }
// System.Console.WriteLine(", Чётных чисел " +count);


//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//  стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int[] array = new int[4];
// int sum = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0,11);
//     Console.Write(array[i] + " ");

//     if (i % 2 == 0)
//     {
//         sum = sum + 0;
//     }
//     else
//     {
//         sum = sum + array[i];
//     }
// }
// System.Console.WriteLine();
// System.Console.Write("Сумма чисел на нечётных позициях " +sum);
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов 
// массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] array = new double[]{4.43, 5.78, 7.62, 5.45, 12.2, 24.8, 13.1};

double max = array [0];
double min = array [0];

for (int i = 0; i < array.Length; i++)
{
    // double r = Convert.ToDouble(x.Next(0, 100) / 100.00);
    // array[i] = new Random().Next(0, 100) * r;
    if (array[i]>max)
    {
        max = array[i];

    }                                       
    if (array[i]<min)
    {
        min = array[i];
    }
    System.Console.Write(array[i]);
    if (i!=array.Length - 1)
    {
        System.Console.Write("; ");
    }
}
double result = max - min;
System.Console.WriteLine();
System.Console.WriteLine("Максимальное число " +max);
System.Console.WriteLine("Минимальное число " +min);
System.Console.WriteLine(result);



