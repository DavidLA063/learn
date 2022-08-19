/*Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.*/
Console.WriteLine ("Введите три числа числа: ");

int numberA = int.Parse( Console.ReadLine () );
int numberB = int.Parse( Console.ReadLine () );
int numberC = int.Parse( Console.ReadLine () );

int maxNumber = numberA;

if ( numberA > maxNumber ) maxNumber = numberA;
if ( numberB > maxNumber ) maxNumber = numberB;
if ( numberC > maxNumber ) maxNumber = numberC;

Console.WriteLine ($"Максимальное число: {maxNumber}");



