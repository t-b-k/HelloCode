// Напишите программу, которая принимает на вход целое неотрицательное число 
// и выдает в качестве результата сумму его цифр


Console.Write("Введите неотрицательное целое число => "); 

if (int.TryParse(Console.ReadLine(), out int n) && n >= 0) 
{
    Console.WriteLine($"Сумма цифр введенного Вами числе равна {SumOfDigits(n)}."); 
}
else
{
    Console.WriteLine("То, что Вы ввели, не является неотрицательным целым числом. \nПрограмма завершает работу. "); 
}

// Метод SumOfDigits возвращает сумму цифр целого неотрицательного числа. 
// Если число не является неотрицательным целым, возвращает ноль. 

int SumOfDigits (int number) 
{
    int sum = 0; 

    while (number > 0) 
    {
        sum = sum + number % 10; 
        number = number / 10; 
    } 
    return sum; 
}