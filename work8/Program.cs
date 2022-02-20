// Показать числа от -N до N
int n = new Random().Next(1,10);
int m = -n;
while (m <= n)
{
  Console.WriteLine(m);
  m=m+1;
}