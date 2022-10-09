Console.Clear();

Console.Write("Введите координаты первой точки ");
int x1 = Convert.ToInt32(Console.Read());
int y1 = Convert.ToInt32(Console.Read());
int z1 = Convert.ToInt32(Console.Read());
Console.Write("Введите координаты второй точки ");
int x2 = Convert.ToInt32(Console.Read());
int y2 = Convert.ToInt32(Console.Read());
int z2 = Convert.ToInt32(Console.Read());

double dist = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1));
Console.WriteLine(Math.Round(dist,2));
