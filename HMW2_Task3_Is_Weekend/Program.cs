// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Write("Введите номер дня недели (от 1 до 7) => "); 

bool isParsed = int.TryParse(Console.ReadLine(), out int number); 

if (!isParsed || number < 1 || number > 7) 
{
    Console.WriteLine("То, что Вы ввели, не является целым числом в диапазоне от 0 до 7");
}
else
{
    if (number == 6 || number == 7) 
    {
        Console.WriteLine("Это ВЫХОДНОЙ день"); 
    }
    else 
    {
        Console.WriteLine($"{number}-й день не является выходным"); 
    }
}    
    
