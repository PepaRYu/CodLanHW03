// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первую координату точки A: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату точки A: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью координату точки A: ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первую координату точки B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату точки В: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью координату точки B: ");
int zB = Convert.ToInt32(Console.ReadLine());



var result = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB,2) );

Console.WriteLine(result);