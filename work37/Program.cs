//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int [] array =new int [123];
int schet =0;
for(int i=0; i<array.Length; i++)
 {
     array[i]=new Random().Next(1,300);
    Console.Write($"{array[i],4} ");  
     if (array[i] >= 10 && array[i] <= 99) 
     schet += 1;
 }  
 Console.WriteLine();
Console.WriteLine("Колличество чисел из отрезка от 10 до 99 сопадают с массивом из 123 чисел {0} раз(а)",schet);
