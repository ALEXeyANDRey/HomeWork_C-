// Определить, присутствует ли в заданном массиве, некоторое число
int [] array  =  new int[8];
Random range = new Random();
for (int i=0; i<array.Length; i++)
{
    array[i] = range.Next(0,100);
    Console.Write($"{array[i],3}");
}
Console.WriteLine();
Console.Write("Число ");
string s = Console.ReadLine();
int chislo = Int16.Parse(s);
int net = 0;
for (int j = 0; j < array.Length; j++)
{
    if (chislo == array[j]) 
    
    Console.WriteLine("Есть в массиве");
    else
    {
     System.Console.WriteLine("Нету в массиве",net);
    }
            
}
