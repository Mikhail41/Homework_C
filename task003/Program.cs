//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Данная программа определяет, является число четным или нет");
Console.WriteLine("Введите число :");
int num = Convert.ToInt32(Console.ReadLine());
int result = num % 2;
Console.WriteLine("Остаток от деления на два = " + result);
if (result == 0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число не является четным");
}