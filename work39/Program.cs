/* Найти произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.*/
int [] array = new int [6];
int sum = 0;
Console.Write("Массив: ");
for (int i = 0; i < array.Length; i++)
{
 array[i]=new Random().Next(0,50);
  Console.Write($"{array[i],3}"); 
}
Console.WriteLine();
for (int j = 0; j < array.Length/2; j++)
{
 sum = array[j]*array[array.Length - 1 - j];
  Console.Write("Произведение пар чисел {0} и {1}",array[j],array[array.Length - 1 - j]);
  Console.WriteLine($"{sum,5}");
}