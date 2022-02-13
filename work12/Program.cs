// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int i = new Random().Next(10, 99);
Console.WriteLine("Число: " +i);
        int a = i % 10;
        int b = (i % 100 - i % 10) / 10;
         if (a>b)
          {
             Console.WriteLine("Наибольшая цифра"+a);
          }
         else
         {
             Console.WriteLine("Наибольшая цифра"+b);
         }
       