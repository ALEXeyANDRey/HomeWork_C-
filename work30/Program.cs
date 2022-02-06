// показать кубы чисел, заканчивающиеся на четную цифру 
int[] a ={1,3,5,6,3,7,4,3,7,8,12,54,35};
for (int i = 0; i < a.Length; i++)
   if(a[i]%2==0)      
         System.Console.WriteLine("{0} {1}", a[i], Math.Pow(a[i],3)); 