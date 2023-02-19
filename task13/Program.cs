//принимает на вход координаты двух точек и находит разницу между ними 
//в 2D пространстве
Console.Clear();
Console.Write("Введите Х1: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите Y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Введите X2: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите Y2: ");
double y2 = double.Parse(Console.ReadLine());
double d1 = Math.Sqrt(-5);
double d = Math.Sqrt(Math.Pow(x1-x2, 2)+ Math.Pow(y1-y2, 2));
Console.WriteLine($"d={d:f3}, {d1}");
