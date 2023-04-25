Console.Write("Введите сторону 1");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите сторону 2");
double y = double.Parse(Console.ReadLine());
Console.Write("Введите сторону 3");
double z = double.Parse(Console.ReadLine());

if (x == y && x == z && y == z) Console.WriteLine("Треугольник равносторонний");
else Console.WriteLine("Треугольник не равносторонний");