/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */


int[] Array = GetArray(10, 0, 99);
Console.WriteLine(String.Join(" ", Array));
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {FindOdd(Array)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int FindOdd(int[] array)
{
    int odd = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) 
        odd = odd + array[i];
    }
    return odd;
}
