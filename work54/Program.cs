// В матрице чисел найти сумму элементов главной диагонали
Input(out int x, out int y);
int[,] xy = new int [x,y];
FillArray (xy);
System.Console.WriteLine();

Solve (out int sum);


void Input (out int x,out int y)
{
    System.Console.Write("Кол-во строк - ");
    x = int.Parse(Console.ReadLine());
    System.Console.Write("Кол-во столбов - ");
    y = int.Parse(Console.ReadLine());
}
void FillArray (int [,] xy)
{
    for (int i = 0; i < xy.GetLength(0); i++)
    {
        for (int j = 0 ; j < xy.GetLength(1); j++)
        {
            xy[i,j] = new Random().Next(1,10);
            System.Console.Write($"{xy[i,j]} ");
        }
       System.Console.WriteLine();
    }
}
void Solve(out int sum)
{
    sum = 0;
    for (int i = 0; i < xy.GetLength(0); i++)
    {
        for (int j = 0 ; j < xy.GetLength(1); j++)
        {
            if (i==j) 
            sum += xy[i,j];
            
        }
    }
    System.Console.WriteLine($"Сумма чисел по диагонали равна {sum} ");
}