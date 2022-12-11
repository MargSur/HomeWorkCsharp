/* Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */


/* Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

/* int count = 5;

int[] array = new int[count];

int endNum = array.Length / 2;

if (array.Length % 2 == 1) endNum++;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 11);
}
Console.WriteLine(string.Join(", ", array));

int[] array2 = new int[endNum];

int j = array.Length - 1;

for (int i = 0; i < array.Length / 2; i++)
{
    array2[i] = array[i] * array[j - i];
}
if (array.Length % 2 == 1)
{
    array2[endNum-1] = array[endNum-1];
}
Console.WriteLine(string.Join(", ", array2)); */


/* foreach (int el in array)
{
    if (el >= 10 && el < 100)
    {
        count++;
    }
}
Console.WriteLine(count); */



int size = array.Length / 2;
    if (array.Length % 2 == 1) size++;
    int[] result = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1) result[size-1] = array[array.Length / 2];
    return result;
