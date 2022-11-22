// Напишите программу, которая принимает на вход три числа
// и выдает максимальное из этих трех чисел

Console.Clear();

Console.Write("Введите целое число а => ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите целое число b => ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите целое число с => ");
int c = int.Parse(Console.ReadLine());

Console.WriteLine(); 
Console.Write("Результат: Число ");

if (a>b) 
{
    if (a>c) Console.Write(a); 
    else Console.Write(c); 
} 
else
{
    if (b>c) Console.Write(b);
    else Console.Write(c); 
}

Console.WriteLine(" является максимальным из трех введенных чисел. "); 
Console.WriteLine(); 
