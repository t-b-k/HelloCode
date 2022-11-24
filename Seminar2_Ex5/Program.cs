// Напишите программу, которая принимает на вход два числа
// и проверяет, является ли одно число квадратом другого

Console.Write("Введите первое целое число => "); 

bool isParsed = int.TryParse(Console.ReadLine(), out int number1); 
// int number = int.Parse(Console.ReadLine()); 

if (!isParsed) 
{
    Console.WriteLine("То, что Вы ввели, не является целым числом!!!");
    return; 
}

Console.Write("Введите второе целое число => "); 

isParsed = int.TryParse(Console.ReadLine(), out int number2); 
// int number = int.Parse(Console.ReadLine()); 

if (!isParsed) 
{
    Console.WriteLine("То, что Вы ввели, не является целым числом!!!");
    return; 
}

if (number1 == number2*number2) 
{
    Console.WriteLine($"Число {number1} является квадратом числа {number2}");
}
else
{ 
    if (number2 == number1*number1) 
    {
        Console.WriteLine($"Число {number2} является квадратом числа {number1}");
    }
    else  
    {
        Console.WriteLine("Ни одно из чисел не является квадратом другого"); 
    }
}

