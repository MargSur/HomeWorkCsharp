/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */


int[] Array = GetArray(10, 100, 999);
Console.WriteLine(String.Join(" ", Array));
Console.WriteLine($"Значения в массиве принимают четное значение {FindEven(Array)} раз(а)");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int FindEven(int[] array)
{
    int even = 0;
    foreach (var item in array)
    {
        if (item % 2 == 0) 
        even++;
    }
    return even;
}