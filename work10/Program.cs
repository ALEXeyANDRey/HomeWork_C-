// Показать последнюю цифру трёхзначного числа
double i = new Random().Next(100,999);
        double a = i % 10;
        Console.WriteLine("Число: "  + i);
        Console.WriteLine("Последняя цифра: " +  a);