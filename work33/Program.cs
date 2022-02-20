/* Задать массив из 12 элементов, заполненных числами из [-9, 9]. 
Найти сумму положительных/отрицательных элементов массива*/
int[] array= new int [12];
Random range= new Random();
int pol = 0;
int neg = 0;
for (int i=0; i<array.Length; i++)
{
    array[i] = range.Next(-9,10);
    Console.Write(array[i]+ " ");
    if (array[i] > 0)
     {
         pol += array[i];
     }
     else
     {
         neg += array[i];
     }
}
Console.WriteLine();
Console.WriteLine("Сумма положительных равна " +pol);
Console.WriteLine("Сумма отрицательных равна {0} ",neg);