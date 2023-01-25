
Console.Write("Введите число: ");
string? a = Console.ReadLine();
int sum = 0;
for (int i = 0; i < a.Length; i++)
{
  sum = sum + Convert.ToInt32(a[i].ToString());
}
Console.WriteLine($"Сумма цифр равна = {sum}");