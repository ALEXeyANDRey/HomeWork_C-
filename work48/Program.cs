// Показать двумерный массив размером m×n заполненный целыми числами
int m,n;
string m1,n1;
Console.Write("Кол-во строк ");
m1 = Console.ReadLine();
m = Convert.ToInt32(m1);
Console.Write("Кол-во столбов ");
n1 = Console.ReadLine();
n = Convert.ToInt32(n1);
int [,] arr = new int [m,n];
for (int i = 0; i < arr.GetLength(0); i++)
 {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i,j] = new Random ().Next(1,10);
          Console.Write( arr[i,j]+ " ");
    }
    Console.WriteLine();
 }

