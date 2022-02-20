// Написать программу вычисления произведения чисел от 1 до N
int a; 
int sum=1 ;
Console.Write("Произведение чисел от 1 до ");
a = Int32.Parse(Console.ReadLine());
for (int i = 1;i<=a;i++)
{
   sum *= i;
}
System.Console.Write("Равняется {0} ", sum);