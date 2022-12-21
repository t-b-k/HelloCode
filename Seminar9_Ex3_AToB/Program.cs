// Напишите программу, которая на вход принимает два числа - А и В - 
// и возводит число А в целую степень В с помощью рекурсии

using static Common.Helper;
using System.Diagnostics; 

int numberA = 0;
int numberB = 0;

if (!InputPositiveInteger("Введите положительное целое => ", out numberA) ||
    !InputPositiveInteger("Введите положительное целое => ", out numberB))
{
    Console.WriteLine("Вы не справились с вводом чисев! |\n");
    return;
}
else
{   
    double num; 
    Stopwatch watch = new Stopwatch(); 
    watch.Start(); 
    // Thread.Sleep(1000); 
    for (int i = 0; i < 1000000; i++)
    {
        num = NumberAToNumberB(numberA, numberB); 
    }
    watch.Stop(); 
    Console.WriteLine($"Метод c рекурсией срабатывает за {watch.ElapsedMilliseconds} мс"); 

    watch.Start(); 
    for (int i = 0; i < 1000000; i++)
    {
        num = GetExponential(numberA, numberB); 
    }
    watch.Stop(); 
    Console.WriteLine($"Метод без рекурсии срабатывает за {watch.ElapsedMilliseconds} мс"); 

    // Console.WriteLine($"{numberA} в степени {numberB} равно {NumberAToNumberB(numberA, numberB)}\n");
}

// int NumberAToNumberB(int a, int b)
// {
//     if (b == 0)
//     {
//         return 1;
//     }
//     else
//     {
//         return a * NumberAToNumberB(a, b - 1);
//     }
// }

double NumberAToNumberB (int a, int b)
{
    if (b == 0) 
    {
        return 1;
    }
    else
    {
        if (b % 2 == 0)
        {
            return (NumberAToNumberB(a, b / 2) * NumberAToNumberB(a, b / 2));
        }
        else
        {
            return (a * NumberAToNumberB(a, b - 1));
        }
    }
}

double GetExponential(int a, int b) {
    double result = 1;
    if(b == 0) {
        return 1;
    }

    for(int i = 0; i < Math.Abs(b); i++) {
        result = result * a;
    }

    if(b < 0) {
        return 1 / result;
    }

    return result;
}

