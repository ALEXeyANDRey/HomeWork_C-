// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double [] array =new double[10];
double max, min ;
Console.Write("Массив: ");
for (int i = 0; i < array.Length; i++)
{
 array[i]=new Random().Next(0,50);
  Console.Write($"{array[i],3}"); 
}
max = array[0];
min = array[0];
Console.WriteLine();
for (int j = 0; j < array.Length; j++)
{
 if (array[j] > max)
   max = array[j];
 if (array[j] < min) 
   min = array[j]; 
}
Console.Write("Разница между между максимальным и минимальным элементом " +(max - min));   