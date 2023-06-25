Console.Write( "Введите число1 ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write( "Введите число2 ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write( "Введите число3 ");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB && numberA > numberC)
{
    Console.WriteLine("Максимальное число" + numberA);
}
else 
{
    Console.WriteLine("Максимальное число" + numberC);
}
if  (numberB > numberC)
{
    Console.WriteLine("Максимальное число" + numberB);
}