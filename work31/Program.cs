// Задать массив из 8 элементов и вывести их на экран
int[] array= new int [8];
Random range= new Random();
int elem = 0;
for (int i=0; i<array.Length; i++)
{
    array[i] = range.Next(0,100);
    elem++;
    Console.WriteLine("{0} элемент массива - {1}", elem ,array[i]);
}