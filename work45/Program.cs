// Показать числа Фибоначчи
int[] ArrayF =new int [20];
ArrayF[0] = 1;
ArrayF[1] = 1;
for (int i = 2; i < ArrayF.Length; i++)
     {
      ArrayF[i] = ArrayF[i - 1] + ArrayF[i - 2];
      Console.WriteLine("Число Фибаначи {0} равно {1}",i, ArrayF[i]);
     }