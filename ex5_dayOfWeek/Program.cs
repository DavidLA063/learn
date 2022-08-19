/*  Напишите программу, которая будет выдавать 
название дня недели по заданному номеру. */

Console.WriteLine ("Введите число от 1 до 7: ");


int dayNumber = int.Parse( Console.ReadLine () );


if (dayNumber == 1)  
Console.WriteLine ("Сегодня понедельник");

if (dayNumber == 2)  
Console.WriteLine ("Сегодня вторник");

if (dayNumber == 3)  
Console.WriteLine ("Сегодня Среда");

if (dayNumber == 4)  
Console.WriteLine ("Сегодня четверг");

if (dayNumber == 5)  
Console.WriteLine ("Сегодня пятница");

if (dayNumber == 6)  
Console.WriteLine ("Сегодня суббота");

if (dayNumber == 7)  
Console.WriteLine ("Сегодня воскресенье");