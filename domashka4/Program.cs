﻿/*
Задача 4. Напишите программу, которая на вход принимает число (number), а на выходе выводит все чётные числа от 1 до number (включительно), разделеные знаком табуляции.

number = 5 -> 2    4
number = 8 -> 2    4    6    8
*/

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= number; i = i + 2)  // Всегда три показателя: точка входа, условия выхода из цикла, шаг
{
    System.Console.Write(i + "\t");
}