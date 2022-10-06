/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/


Random rnd = new Random();
int[] mas = new int[10];
int max = 0;
int min = 99;
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = rnd.Next(1, 99);
}
for (int i = 0; i < mas.Length; i++)
{
    if (mas[i] > max) max = mas[i];
    if (mas[i] < min) min = mas[i];
}
for (int i = 0; i < mas.Length; i++)
{
    Console.Write(" " + mas[i]);
    Console.WriteLine();
    Console.WriteLine("Минимальный элемент:  " + max);
    Console.WriteLine("Минимальный элемент:  " + min);
    Console.WriteLine("Разница между элементами:  " + (max - min));
}