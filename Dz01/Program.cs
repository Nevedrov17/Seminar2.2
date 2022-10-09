Console.Clear();

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;
int c = 0;
if (a > 9999)
{
    while (a > 99)
    {
        a= a/10;
    }
}
else Console.WriteLine("Число не 5-ти значное");