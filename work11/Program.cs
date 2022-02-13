// Показать вторую цифру трёхзначного числа
int i = new Random().Next(100, 999);
        Console.WriteLine("Число: " + i);
        int a = (i % 100 - i % 10) / 10;
        Console.WriteLine("Вторая цифра: " +a );