﻿/*  Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N.   5 -> 2, 4  */

Console.WriteLine ("Введите число :");
int numA = int.Parse( Console.ReadLine () );

for (int i = 0; i <= numA; i+=2)
{
    Console.WriteLine(i);
}