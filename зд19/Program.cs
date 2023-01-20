Console.WriteLine("Введите число: ");
string x = Console.ReadLine();
int len = x.Length;

if (len == 5)
{
if (x[0] == x[4] && x[1] == x[3])
{
 Console.WriteLine($"{x} - Палиндром");
}
else
{
 Console.WriteLine($"{x} - Не палиндром");
}
}
else
{
Console.WriteLine($"Число {x} - не является пятизначным");
}