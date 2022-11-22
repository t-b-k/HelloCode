// Задача 1
// Напишите программу, которая на вход принимает два числа и выдает, 
// какое из чисел больше, а какое меньше

Console.Clear();

Console.Write("Введите целое число а => ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите целое число b => ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine(); 
Console.Write("Результат: ");

if (a==b) 
{
    Console.WriteLine("Числа a и b равны"); 
    Console.Write(a); 
    Console.Write("  и ");
    Console.Write(b); 
    Console.WriteLine(" равны. "); 
}
else
{
    if (a>b) 
    {
        Console.Write("Число "); 
        Console.Write(a); 
        Console.Write("  больше числа ");
        Console.Write(b); 
        Console.WriteLine("."); 
    }
    else 
    {
        Console.Write("Число "); 
        Console.Write(b); 
        Console.Write("  больше числа ");
        Console.Write(a); 
        Console.WriteLine("."); 
    }    
}
Console.WriteLine(); 
