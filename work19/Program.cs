// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.WriteLine("Введите x: ");
int x = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите y: ");
int y = Convert.ToInt16(Console.ReadLine());
if ((x > 0) && (y > 0))
    {
         Console.WriteLine("I четверть");
    }
else
    if ((x < 0) && (y > 0))
       {
           Console.WriteLine("II четверть");
       }
else
    if ((x < 0) && (y < 0))
      {
        Console.WriteLine("III четверть");
      } 
 else
     if ((x > 0) && (y < 0))
       {
           Console.WriteLine("IV четверть");
       } 