// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

for (!(x||y)==!x&&!y)
{
    System.Console.WriteLine("True");
}
else
{
    System.Console.WriteLine("False");
}