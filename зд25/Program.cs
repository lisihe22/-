Console.Write("введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int x = a;

    for (int i = 1; i < b; i++)
{
        x = x*a;
}
Console.WriteLine($"Число {a} в степень {b} = {x}");