// По двум заданным числам проверять является ли первое квадратом второго 
Console.WriteLine("Введите первое число ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int n1 = int.Parse(Console.ReadLine());
if (n1 * n1 == n)
Console.WriteLine("yes");
else Console.WriteLine("no");