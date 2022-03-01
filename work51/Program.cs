// Задать двумерный массив следующим правилом: Aₘₙ = m+n

Input (out int m, out int n);
int [,] mn = new int[m,n];

FillArray (mn);


void Input (out int m, out int n)
{
    string s = string.Empty;
    System.Console.Write("Кол-во строк - ");
    s = Console.ReadLine();
    m = Convert.ToInt16(s);
    System.Console.Write("Кол-во столбцов - ");
    s = Console.ReadLine();
    n =Convert.ToInt16(s);
}


void FillArray (int[,]mn)
{
   for (int i = 0; i < mn.GetLength(0); i++)
     {
       for (int j = 0; j < mn.GetLength(1) ; j++)
       {
         mn[i,j] = i + j;
         System.Console.Write($"{mn[i,j]} ");
       }
       System.Console.WriteLine();
     }
}