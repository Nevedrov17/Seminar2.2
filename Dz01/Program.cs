Console.Clear();

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int b = a%100;
int x1 = b%10;
int x2 = b/10;

    while (a > 99)
    {
        a= a/10;
    }
int y1 = a/10;
int y2 = a%10;

if (x1 == y1 && x2 == y2)
{
    Console.WriteLine("Число является полиндромом");
}
else Console.WriteLine("Число не является полиндромом");
