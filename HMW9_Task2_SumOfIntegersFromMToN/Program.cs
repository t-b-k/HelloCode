// Задайте значения M и N (M < N). Напишите программу, которая выведет 
// всех целых чисел в промежутке от M до N. Выполнить с помощью рекурсии.

using static Common.Helper;
using System.Diagnostics;

// Ввод целых чисел M и N

int m = 1;
int n = 1;

Console.WriteLine("Программа посчитает и выведет на экран ");
Console.WriteLine($"сумму всех чисел от M до N включительно (если M <= N)\n");

// int sum = 0;

if (InputInteger("Введите натуральное число M => ", out m) &&
    InputInteger("Введите натуральное число N => ", out n) &&
    m <= n)
{
    Console.WriteLine("С рекурсией: \n");

    Stopwatch watch = new Stopwatch();
    watch.Start();

    int repeatNumber = 1000000; 

    double sumRec = 0;
    for (int i = 1; i <= repeatNumber; i++) sumRec = SumOfIntegers(m, n);
    Console.WriteLine($"\nСумма чисел от {m} до {n} равна {sumRec}\n");
    watch.Stop();
    Console.WriteLine($"Метод c рекурсией срабатывает {repeatNumber} раз за {watch.ElapsedMilliseconds} мс\n");

    watch.Start();

    Console.WriteLine("Без рекурсии: \n");
    double sumFor = 0; 
    for (int j = 1; j < repeatNumber; j++)
    {
        sumFor = 0;
        for (int i = m; i <= n; i++) sumFor = sumFor + i;
    }
    Console.WriteLine($"\nСумма чисел от {m} до {n} равна {sumFor}\n");
    watch.Stop();
    Console.WriteLine($"Метод без рекурсии срабатывает {repeatNumber} раз за {watch.ElapsedMilliseconds} мс\n");

}
else
{
    Console.WriteLine("Введенные Вами данные не удовлетворяют условию задачи!\n");
    return;
}

double SumOfIntegers(int m, int n)
{
    if (n >= m)
    {
        if (n == m) return n;
        else return m + SumOfIntegers(m + 1, n);
    }
    else
    {
        Console.WriteLine($"Печатать нечего, извините: {n} < {m}\n");
        return 0;
    }
}
