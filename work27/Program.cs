// Определить количество цифр в числе
Console.Write(" Число ");
string str = Console.ReadLine();
int x = Convert.ToInt32(str);
int schet = 0;
   while ( x > 0 )
        {
            schet++;
            x = x / 10;
        }  
Console.Write(" состоит из {0} цифр " , schet);