﻿/*
28. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

System.Console.Write("Введите число: ");
int userNum = Convert.ToInt32(Console.ReadLine());

int Number(int n)
{
    int num = 1;

    for (int i = 1; i <= n;  i++)
    {
         num = num * i;
    }
    return num;
}
int userResult = Number(userNum);
System.Console.WriteLine(userResult);