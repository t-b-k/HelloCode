// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

using static Common.Helper;

// Ввод натурального числа N

uint n = 1;
uint m = 1;

Console.WriteLine("Программа выводит на экран последовательно в порядке убывания ");
Console.WriteLine("все натуральные числа от N до {m} \n");

if (InputPositiveInteger("Введите натуральное число N => ", out n))
{
    PrintByDescender(n,m); 
}
else
{
    Console.WriteLine("Введенное Вами число не является натуральным!\n"); 
}

// void PrintByDescender(uint n, uint m)
// {
//     if (n >= m)
//     {
//         if (n == m) Console.WriteLine(n);
//         else
//         {
//             Console.Write($"{n}, ");
//             PrintByDescender(n - 1, m);
//         }
//         return;
//     }
//     else
//     {
//         Console.WriteLine($"Печатать нечего, извините: {n} < {m}\n"); 
//     }
// }