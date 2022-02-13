// Удалить вторую цифру трёхзначного числа
int i = new Random().Next(100, 999);
Console.WriteLine("Трёхзначное число: "+ i);
        int a = i % 10;
        int b = (i % 1000 - i % 100) / 10;
        Console.WriteLine("Трёхзначное число без второй цифры: " + b + a);