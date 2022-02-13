// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер четверти: ");
int i = Convert.ToInt16(Console.ReadLine());
switch (i)
{
    case 1: Console.WriteLine("Диапазоны (x > 0)  (y > 0)"); break;
    case 2: Console.WriteLine("Диапазоны (x < 0)  (y > 0)"); break;
    case 3: Console.WriteLine("Диапазоны (x < 0)  (y < 0)"); break;
    case 4: Console.WriteLine("Диапазоны (x > 0)  (y < 0)"); break;
}
