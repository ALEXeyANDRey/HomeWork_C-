// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Write("Введите число: ");
int num = Convert.ToInt16(Console.ReadLine());
switch (num)
{
    case 1: Console.WriteLine("Будний день"); break;
    case 2: Console.WriteLine("Будний день"); break;
    case 3: Console.WriteLine("Будний день"); break;
    case 4: Console.WriteLine("Будний деньг"); break;
    case 5: Console.WriteLine("Будний день"); break;
    case 6: Console.WriteLine("Выходной день"); break;
    case 7: Console.WriteLine("Выходной день");break;
    default: Console.WriteLine("Неверно введен день недели"); break;
}