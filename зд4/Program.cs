   Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
   Console.Write("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());
   Console.Write("Введите число 3: ");
int c = Convert.ToInt32(Console.ReadLine());

{ 
if (a > b && a > c)
Console.WriteLine(a);
else if (a<b && b<c)
Console.WriteLine (c);
else if (a<b && b>c)
Console.WriteLine (b);
}
//Console.WriteLine (c);
//if (b > a )
//Console.WriteLine(b);
//else if (c > b )
//Console.WriteLine(c);


// if (c < b) 
//Console.WriteLine(b);
//if (c < a)
//Console.WriteLine(a); 


