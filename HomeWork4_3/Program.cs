/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */


Console.Write("Введите количество элементов массива: ");
int elementsCount = int.Parse(Console.ReadLine());

int [] array = new int[elementsCount];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}: ");
    array[i] = int.Parse(Console.ReadLine());
}

Console.Write($"[{String.Join(", ", array)}]");