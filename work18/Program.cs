// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool x = 2;
bool y ;
if (!(x || y) == !x && !y)
{
    System.Console.WriteLine("True");
}
else
{
    System.Console.WriteLine("False");
}