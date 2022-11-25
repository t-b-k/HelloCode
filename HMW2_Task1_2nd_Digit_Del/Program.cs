// Напишите программу, которая принимает на вход трехзначное число 
// и на выходе показывает вторую цифру этого числа

Console.Write("Введите трехзначное натуральное число => "); 

bool isParsed = int.TryParse(Console.ReadLine(), out int number); 

if (!isParsed) 
{
    Console.WriteLine("То, что Вы ввели, не является целым числом");
    return; 
}
else
{
    if (number <= 0) 
    {
        Console.WriteLine("То, что Вы ввели, не является натуральным числом"); 
        return; 
    }
    else
    {
        if (number < 100 || number > 999) 
        {
            Console.WriteLine("То, что Вы ввели, не является трехзначным натуральным числом"); 
            return; 
        }
    }
}

int result = number / 10 % 10; 
Console.WriteLine($"Второй цифрой в Вашем числе является цифра {result}"); 
