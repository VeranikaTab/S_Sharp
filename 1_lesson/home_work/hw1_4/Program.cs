﻿// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Ведите число N: ");
string a = Console.ReadLine();
int N = int.Parse(a);
int N1 = 2;

while (N1 < N)
{
    if (N1 > 1)
    {
        Console.WriteLine("четные числа заданного числа N: "+N1);
        
    }
    N1 +=2;
}