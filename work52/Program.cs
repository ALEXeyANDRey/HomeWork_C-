// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
Input(out int x, out int y);
int [,] arr = new int [x,y];
FillArray(arr); 
System.Console.WriteLine();  
Solve(arr);                            

void Input (out int x, out int y)
{
   
    System.Console.Write("Кол-во строк - ");
    x = int.Parse(Console.ReadLine());
    System.Console.Write("Кол-во столбцов - ");
    y =int.Parse(Console.ReadLine());
}
void FillArray (int [,] a)
{
    for (int i = 0; i < a.GetLength(0);i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i,j] = new Random().Next (1,10);
            System.Console.Write($"{a[i,j]}  ");
        }
        System.Console.WriteLine();
    }
}
void Solve (int [,]a)
{
    for (int i = 0; i < a.GetLength(0);i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (i%2==0 && j%2 == 0)
            System.Console.Write("{0} " ,Math.Pow (a[i,j], 2));
            else
            System.Console.Write($"{a[i,j]} ");
        }
        System.Console.WriteLine();
    }
}