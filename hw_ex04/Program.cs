/*Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.*/

int numberA = 8;
int numberB = 10;
int numberC = 2;

int maxNumber = numberA;

if ( numberA > maxNumber ) maxNumber = numberA;
if ( numberB > maxNumber ) maxNumber = numberB;
if ( numberC > maxNumber ) maxNumber = numberC;

Console.Write (maxNumber);


