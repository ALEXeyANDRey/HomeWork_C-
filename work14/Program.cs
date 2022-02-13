// Выяснить, кратно ли число заданному, если нет, вывести остаток.
int i = new Random().Next(10, 99);
Console.WriteLine("Первое число: "+i);
int j = new Random().Next(10, 99);
Console.WriteLine("Второе число: "+j);
 if (i%2==j%2)
   {
     Console.WriteLine(true);
   }
   else 
   {
       double y = (i%j);
       Console.WriteLine(y);
   }