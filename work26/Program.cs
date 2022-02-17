// Возведите число А в натуральную степень B используя цикл
Console.Write("Введите число: ");
int a = Convert.ToInt16(Console.ReadLine());
int sum = 1;
Console.Write("Введите степень: ");
int b = Convert.ToInt16(Console.ReadLine());
for (int i = 0; i < b; i++)
    {
        sum = sum * a;
    }
    Console.WriteLine(sum);