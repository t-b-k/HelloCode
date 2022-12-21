// Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр

using static Common.Helper;

int number = 0; 

if (!InputPositiveInteger("Введите положительное целое => ", out number))
{   
    Console.WriteLine("Вы не справились с вводом числа! |\n"); 
    return; 
}
else
{
    Console.WriteLine($"Сумма цифр числа {number} равна {SumOfDigits(number)}\n"); 
}

int SumOfDigits (int n)
{
    if (n / 10 == 0) 
    {
        return n; 
    }
    else
    {
        return SumOfDigits(n/10) + n%10; 
    }
}





