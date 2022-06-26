Console.WriteLine("Введите первое число :");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число :");
int b = Convert.ToInt32(Console.ReadLine());

if (b > a)
{
    Console.WriteLine("Максимальное число = ");
    Console.WriteLine(b);
    Console.WriteLine("Минимальное число = ");
    Console.WriteLine(a);
}
else
{
    Console.WriteLine("Максимальное число = ");
    Console.WriteLine(a);
    Console.WriteLine("Минимальное число = ");
    Console.WriteLine(b);
}