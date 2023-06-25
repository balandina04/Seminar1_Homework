Console.Write("Введите число ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);
int number2 = 2;
    if (number % number2 == 0)
{
    Console.WriteLine("Это четное число" + number);
}
    else
{
    Console.WriteLine("Это нечетное число" + number);
}
