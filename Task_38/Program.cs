﻿/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
/*
int size = 5;
int[] arr = new int[size];
Random rnd = new Random();
for (int i = 0; i < arr.GetLength(0); i++)
{
arr[i] = rnd.Next(1, 100);
Console.WriteLine(+ arr[i]);
}
*/
            int a, i, n;
            int[] m = new int[100];
 
            Random rand = new Random();
            n = 5;
            Console.WriteLine("Исходный массив");
            for (i = 0; i < n; i++)
            {
                m[i] = rand.Next(0, 50);
                Console.Write(m[i] + " ");
            }
 
            var min = m[0];
            var max = m[0];
 
            for (i = 0; i < n; i++)
            {
                if (m[i] < m[min])
                {
                    min =i;
                }
                else if (m[i] > m[max])
                {
                    max =i;
                }
            }
            Console.WriteLine("Минимальный элемент: " + m[min]);
            Console.WriteLine("Максимальный элемент: " + m[max]);
            for (i = 0; i < n; i++)
            {
                Console.Write(m[i] + " ");
            }
            Console.WriteLine("\n Элементы между минимум и максимом" + m[i]);
            for ( i=min+1;i<max;i++); //Console.Write(m[i]+" ");
 