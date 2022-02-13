// Дано число. Проверить кратно ли оно 7 и 23
int i = new Random().Next(160, 162);
Console.WriteLine("Число "+i);
int chislo1 = 7;
int chislo2 = 23; 
if  (i % chislo1 == 0 && i % chislo2 == 0)
 {
     Console.WriteLine($"кратно {chislo1}  и {chislo2}");
 }
  else
  {
      Console.WriteLine($"не кратно {chislo1}  и {chislo2}");
  }

