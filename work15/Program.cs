// Найти третью цифру числа или сообщить, что её нет
int i = new Random().Next(1, 200);
int kol = 1;
if (i/100 < kol)
    {  
      System.Console.WriteLine("Число {0} не трёхзначное " ,i);
    }
else 
    {
       int a = i % 10;
       System.Console.WriteLine("У числа {0} - третья цифра {1} " ,i, a);
    }
 
