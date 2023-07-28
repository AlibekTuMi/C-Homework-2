// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X не равен 0 и Y не равен 0 и выдаёт номер четверти плоскости, в которой
// находится эта точка.

// Console.WriteLine("Введите число X");
// int X = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число Y");
// int Y = Convert.ToInt32(Console.ReadLine());

// if (X > 0 && Y > 0)
// {
//     Console.WriteLine("1 Четверть");
// }
// else if(X < 0 && Y > 0)
// {
//     Console.WriteLine("2 Четверть");
// }
// else if(X < 0 && Y < 0)
// {
//     Console.WriteLine("3 Четверть");
// }
// else if(X > 0 && Y < 0)
// {
//     Console.WriteLine("4 Четверть");
// }
// else
// {
//     Console.WriteLine("Точка лежит на оси");
// }


// Напишите программу, которая по заданному номеру четверти показывает 
// диапазон возможных координат точек в этой четверти (X и Y).

// Console.WriteLine("Введите номер четверти");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num ==1)
// {
//     Console.WriteLine("X и Y больше 0");
// }
// else if(num ==2)
// {
//     Console.WriteLine("X меньше 0, а Y больше 0");
// }
// else if(num ==3)
// {
//     Console.WriteLine("X и Y меньше 0");
// }
// else if(num ==4)
// {
//     Console.WriteLine("X больше 0, а Y меньше 0");
// }
// else
// {
//     Console.WriteLine("Ведите число от 1 до 4");
// }



// Console.WriteLine("Введите число :");
// int num = Convert.ToInt32(Console.ReadLine());

// switch(num)
// {
//     case 1:
//     {
//         Console.Write("X>0 Y>0");
//         break;
//     }
//     case 2:
//     {
//         Console.Write("X<0 Y>0");
//         break;
//     }
//     case 3:
//     {
//         Console.Write("X<0 Y<0");
//         break;
//     }
//     case 4:
//     {
//         Console.Write("X>0 Y<0");
//         break;
//     }
//     default:
//     {
//         Console.Write("Не подходит");
//         break;
//     }
// }


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
// между ними в 2D пространстве.
// A (3,6); B (2,1) ->5,09
// A (7,-5); B (1,-1) ->7,21


// Console.WriteLine("Введите число X1 : ");
// int X1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число Y1 : " );
// int Y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число X2 : ");
// int X2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число Y2 : ");
// int Y2 = Convert.ToInt32(Console.ReadLine());

// double s =Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));


// System.Console.WriteLine(s);


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1,4,9,16,25
// 2 -> 1,4

Console.WriteLine("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i<=num; i++)
{
    double s = Math.Pow(i,2);
    Console.WriteLine(s);
}