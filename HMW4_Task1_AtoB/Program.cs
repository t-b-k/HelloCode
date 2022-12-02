// Напишите программу, которая принимает на вход два числа (A и B) 
// и метод который возводит число A в натуральную степень B. 
// Задание должно быть выполнено в методе. 
// В методе не должно быть вывода в консоль. 
// Не использовать Math.Pow()

double a;
int b;

if (inputNonZeroAAndIntegerB (out a, out b)) 
{
    Console.WriteLine($"Вы ввели число А = {a} и число B = {b}. Возведем число А в степень B. ");
    Console.WriteLine($"Ответ: {raisingDoubleAToIntB(a, b)}");
}


bool inputNonZeroAAndIntegerB(out double a, out int b)
{
    a = 0; 
    b = 0; 
    
    Console.WriteLine("Введите число А, отличное от нуля, и целое число B. ");
    
    Console.Write("Введите число A, отличное от нуля ==> ");

    if (double.TryParse(Console.ReadLine(), out double doubleNum))
    {
        if (doubleNum == 0)
        {
            Console.WriteLine("Вы ввели число А, равное нулю. Программа завершает свою работу. ");
            return false;
        }
        else
        {
            a = doubleNum;
        }
    }
    else
    {
        Console.WriteLine("То, что Вы ввели, не является числом. Программа завершает свою работу. ");
        return false;
    }

    Console.Write("Теперь введите целое число В ==> ");

if (!int.TryParse(Console.ReadLine(), out int intNum))
    {
        Console.WriteLine("То, что Вы ввели, не является целым числом. Программа завершает свою работу. ");
        return false;
    }
    else
    {
        b = intNum;
    }
return true; 
}

double raisingDoubleAToIntB(double a, int b)
{
    double res = 1;
    if (b > 0)
    {
        for (int i = 1; i <= b; i++)
        {
            res = res * a;
        }
    }
    else
    {
        if (b < 0)
        {
            for (int i = 1; i <= -b; i++)
            {
                res = res * a;
            }
            res = 1 / res;
        }
    }
    return res;
}