﻿/*  Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает последнюю цифру этого числа.  */

Console.WriteLine ("Введите трехзначное число");

int numA = int.Parse ( Console.ReadLine () );






Console.WriteLine ($"Последняя цифра этого числа: {numA % 10}");

