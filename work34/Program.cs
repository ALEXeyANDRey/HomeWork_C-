// Написать программу замены элементов массива на противоположные
int[] array = new int[8];
Random range = new Random();

for (int i = 0; i < array.Length; i++)
{
    arr[i] = range.Next(-9, 9);
    Console.Write($"{array[i],3}");
}
 Console.WriteLine();
for (int j = 0; j < array.Length; j++)
{
    array[j] = -array[j];
    Console.Write($"{arr[j],3}");
}

