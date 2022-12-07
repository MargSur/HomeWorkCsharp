/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
 */


Console.Write("Введите число А: ");
int num =  Convert.ToInt32(Console.ReadLine());
int count = 0; //количество цифр в числе


while (num > 0)
{
    num /= 10; // A = A/10
    count++;
}
Console.WriteLine($"Количество цифр в числе = {count}");