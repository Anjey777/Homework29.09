﻿/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

Console.WriteLine("Введите размерность массива");
Console.Write("");
int n = int.Parse(Console.ReadLine());
int [] arr = new int[n];
Random rnd = new Random();
for (int i = 0; i < arr.GetLength(0); i++)
arr[i] = rnd.Next(100, 999);
Console.WriteLine("Ваш случайный массив:");
for (int i = 0; i < arr.GetLength(0); i++, Console.WriteLine())
Console.WriteLine ( arr[i]);

int even;
even = 0;
for (int i = 0; i < arr.GetLength(0); i++)
                   if (arr[i] % 2 == 0)
                  even++;
Console.WriteLine($"Количество четных: {even}");