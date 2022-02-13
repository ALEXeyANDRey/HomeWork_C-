// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите первое число ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = int.Parse(Console.ReadLine());
if (b * b == a)
  {
   Console.WriteLine($"{a} = {b} в квадрате");
  }
else 
  {
    Console.WriteLine($"{a} != {b} в квадрате ");
  }
if (a * a == b)
  {
    Console.WriteLine($"{b} = {a} в квадрате");
  }
else
  {
    Console.WriteLine($"{b} != {a} в квадрате ");
  }
