// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
Input(out int x, out int y);
int[,] xy = new int [x,y];
FillArray (xy);
System.Console.WriteLine();
Solve (xy);

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
void Solve (int [,] xy)
{
     System.Console.Write("Число - ");
    int a = int.Parse(Console.ReadLine());
    for (int i = 0; i < xy.GetLength(0);i++)
    {
        for (int j =0; j < xy.GetLength(1);j++)
        {
            if (a==xy[i,j]) System.Console.WriteLine("есть на позициях: строка - {0}, столбец - {1} ",i,j);
            
        }
        
    }
}