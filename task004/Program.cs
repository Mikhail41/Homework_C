// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());
int index = 0;
System.Console.WriteLine($"Чётные числа из диапазона от 1 до {num}:");
while (index < num)
{
    index++;
    if (index % 2 == 0) System.Console.Write(index + " ");
}