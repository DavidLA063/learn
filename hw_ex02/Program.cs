/* Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.*/
Console.WriteLine ("Введите два числа: ");

int numberA = int.Parse (Console.ReadLine () );
int numberB = int.Parse (Console.ReadLine () );


if ( numberA > numberB ) {
    Console.WriteLine ($"Большее число: {numberA} ");
    Console.WriteLine ($"Меньшее число: {numberB} ");
    }
    else
    {
        Console.WriteLine ($"Большее число: {numberB}");
        Console.WriteLine ($"Меньшее число: {numberA}");
    }