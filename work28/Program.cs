// Подсчитать сумму цифр в числе
System.Console.WriteLine("Введите любое число");
string s = Console.ReadLine();
int b, c;
int count = 0;
b = Convert.ToInt32(s);

while (b > 0)
{
    c = b % 10;
    count += c;
    b = b / 10;
}

Console.WriteLine("Сумма чисел в вашем числе равна " + count);
