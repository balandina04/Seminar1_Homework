﻿Console.Write( "Введите число ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write( "Введите число ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA < numberB)
{
    Console.WriteLine("Большее число" + numberB);
}
 Console.WriteLine("Меньшее число" + numberA);