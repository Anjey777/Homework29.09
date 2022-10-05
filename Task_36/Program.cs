/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int size = 4;
int[] arr = new int[size];
Random rnd = new Random();
for (int i = 0; i < arr.GetLength(0); i++)
{
arr[i] = rnd.Next(1, 10);
Console.WriteLine(+ arr[i]);
}
int sum = 0;
for (int i = 0; i < size; i++) 
{
    if (arr[i] % 2 != 0) 
        sum += arr[i];
}
Console.WriteLine("Сумма нечетных элементов: "+  sum);
