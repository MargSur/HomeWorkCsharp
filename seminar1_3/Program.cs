﻿// Напищите программу, которая будет выдавать название дня недели по заданному номеру

Console.WriteLine("Enter day number : ");
string enterDay = Console.ReadLine();
int day = Convert.ToInt32(enterDay);
string WeekDay = "Monday";

if (day == 1) WeekDay = "Monday";
if (day == 2) WeekDay = "Tuesday";
if (day == 3) WeekDay = "Wednesday";
if (day == 4) WeekDay = "Thursday";
if (day == 5) WeekDay = "Friday";
if (day == 6) WeekDay = "Saturday";
if (day == 7) WeekDay = "Sunday";

if ((day > 7) || (day < 1))
{
    Console.WriteLine("Day of the week not found, please enter a valid day");
    return;
}
Console.WriteLine(WeekDay);