// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. 

Console.Write("Введите натуральное число => "); 

bool isParsed = int.TryParse(Console.ReadLine(), out int number); 

if (!isParsed || number <= 0) 
{
    Console.WriteLine("То, что Вы ввели, не является натуральным числом");
}
else
{
    if (number < 100) 
    {
        Console.WriteLine("Ваше число меньше 100, 3-я цифра в его записи отсутствует."); 
    }
    else 
    {
        while (number > 999)
        {
            number = number / 10; 
        } 
        
        int result = number % 10; 

        Console.WriteLine($"Третья цифра в Вашем числе равна {result}"); 
    }
}    
    
