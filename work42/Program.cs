// Определить сколько чисел больше 0 введено с клавиатуры
int num ;
int count = 0;
string s;
Console.Write("Число ");
s = Console.ReadLine();
num = Int16.Parse(s);
 while (num > 0)
 {
   if (num%10 != 0) 
   count ++;
   num=num/10;
 }

 Console.Write("состоит из {0} цифры(ер) ",count );   