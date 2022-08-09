Console.WriteLine("Введите число для проверки:");
int Number1 = Convert.ToInt32(Console.ReadLine());

if (Number1 % 2 == 0)
{
    Console.WriteLine("Вы ввели четное число!");
}
else
{
    Console.WriteLine("Вы ввели нечетное число!");
}