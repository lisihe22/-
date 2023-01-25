Console.Write("введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int st = a;

    for (int i = 1; i < b; i++)
{
        st = st*a;
}
Console.WriteLine($"Число {a} в степень {b} = {st}");