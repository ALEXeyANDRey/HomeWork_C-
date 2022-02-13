// Написать программу преобразования десятичного числа в двоичное
int a = new Random().Next(1, 99);
int b = a;
int c;
string s = " ";
c = b;
while(b > 0)
{
    c = b % 2;
    s =c.ToString() + s;
    b = b / 2;
}
System.Console.WriteLine("Число - {0}  в двоичной системе равно {1}", a , s);