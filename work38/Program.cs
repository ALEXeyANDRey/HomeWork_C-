// Найти сумму чисел одномерного массива стоящих на нечетной позиции
int [] array = new int [5];
int sumNe = 0;
Console.Write("Массив: ");
for (int i =0; i < array.Length; i++)
{
  array[i]=new Random().Next(0,50); 
  Console.Write($"{array[i],3}"); 
  if (i % 2 != 1)
   sumNe += array[i];
}

  Console.WriteLine();
  Console.WriteLine("Сумма чисел на нечётной позиции равна {0}" ,sumNe); 
  
 

 