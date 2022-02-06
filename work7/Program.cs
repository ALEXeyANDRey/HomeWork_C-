// Выяснить является ли число чётным
int x;
System.Console.Write("Ввести число: ");
x = int.Parse(Console.ReadLine());
if ((x % 2) == 0)
{
    Console.WriteLine("Чётное");
}
else
{
    Console.WriteLine("Нечетное");
}
