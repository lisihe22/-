
Console.Write("Введите трёхзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = n/10%10;
{
    if (n<=999)
    Console.WriteLine(m);
    else
    Console.WriteLine("Вы ввели не трехзначное число");

}




