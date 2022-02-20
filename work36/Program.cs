// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int [] array =new int [4];
int chet=0;
int nechet=0;
for (int i=0; i<array.Length; i++)
{
 array[i] = new Random().Next(100,999);
 Console.Write($"{array[i]} ",3);

if (array[i]%2==0)
    
    
    chet++;

else

  
    nechet++;
}
Console.WriteLine();
Console.WriteLine("Чётных чисел - {0}",chet);
Console.WriteLine("Нечётных чисел - {0}",nechet);