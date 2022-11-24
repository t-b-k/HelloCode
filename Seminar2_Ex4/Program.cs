// Написать программу, которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23

Console.Write("Введите целое число, отличное от нуля => "); 

bool isParsed = int.TryParse(Console.ReadLine(), out int number); 
// int number = int.Parse(Console.ReadLine()); 

if (!isParsed) 
{
    Console.WriteLine("То, что Вы ввели, не является целым числом!!!");
    return; 
}

int rest7 = number % 7;
int rest23 = number % 23;  

if (rest7 == 0 & rest23 == 0) 
{
    Console.Write($"Поздравляем! Число {number} делится одновременно и на 7, и на 23!");
}
else 
{
    Console.Write($"Число {number} не делится одновременно на 7 и на 23."); 
} 

