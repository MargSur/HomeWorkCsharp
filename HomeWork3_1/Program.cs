/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("enter a five-digit number : ");
int number = Convert.ToInt32(Console.ReadLine());

var num1 = number / 10000;

var num2 = (number - num1*10000) / 1000;

var num3 = (number - num1*10000 - num2*1000) / 100;

var num4 = (number - num1*10000 - num2*1000 - num3*100) / 10;

var num5 = (number - num1*10000 - num2*1000 - num3*100 - num4*10);

if (num1 == num5 && num2 == num4)
{
    Console.WriteLine(number + " -> " + "Это палиндром");
}
else
{
    Console.WriteLine(number + " ->" + "Это не палиндром");
}