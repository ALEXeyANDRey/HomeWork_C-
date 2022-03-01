// В двумерном массиве n×k заменить четные элементы на противоположные

Input(out int n, out int k);
int [,] nk = new int [n, k];
FillArray (nk);
//PrintArray(nk,n,k);
System.Console.WriteLine();
Solve (nk);
//PrintArray(nk,n,k);





void Input (out int n, out int k)
{
    string s = string.Empty;
    System.Console.Write("Кол-во строк - ");
    s = Console.ReadLine();
    n = Convert.ToInt16(s);
    System.Console.Write("Кол-во столбцов - ");
    s = Console.ReadLine();
    k =Convert.ToInt16(s);
}
/*void PrintArray(int [,] nk, int n, int k)
{
    for (int i = 0; i < n; i++)
    {
     for (int j = 0; j < k ; j++)
     {
       System.Console.Write($"{nk[i,j]} ");
     }
     System.Console.WriteLine();
    }
}*/
void FillArray (int [,] nk )
{
    for (int i = 0; i < nk.GetLength(0); i++)
    {
     for (int j = 0; j < nk.GetLength(1); j++)
     {
         nk [i,j]=new Random().Next(1,100);
         System.Console.Write($"{nk[i,j]} ");
     }
     Console.WriteLine();
    }
}
void Solve (int [,] nk )
{
    for (int i = 0; i < nk.GetLength(0); i++)
    {
       for (int j = 0; j < nk.GetLength(1); j++)
       {
           if (nk[i,j]%2 == 0) nk[i,j] *= -1;
            System.Console.Write($"{nk[i,j]} ");
       }
        System.Console.WriteLine();
    }
}