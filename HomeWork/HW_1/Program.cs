﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// System.Console.WriteLine("Input number A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number B: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if(a>b)
// {
//     System.Console.WriteLine($"max {a}");
// }
// else
// {
//     System.Console.WriteLine($"max: {b}");
// }



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// System.Console.WriteLine("Input number A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number C: ");
// int c = Convert.ToInt32(Console.ReadLine());

// int max = a;

// if (b>max) max = b;
// if (c>max) max = c;

// System.Console.WriteLine($"max: {max}");



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// System.Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number%2 == 0)
// {
//     System.Console.WriteLine("yes");
// }
// else
// {
//     System.Console.WriteLine("no");
// }



// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 2;

while(count <= number)
{
    System.Console.WriteLine($"{count}");
    count = count + 2;
}



