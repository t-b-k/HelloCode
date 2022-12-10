// Напишите программу, которая принимает на вход число N 
// и выдает произведение чисел от 1 до N

Console.WriteLine("Введите число: "); 

bool isNumber = int.TryParse(Console.ReadLine(), out int number); 

if (!isNumber) 
{
    Console.WriteLine("Вы ввели что-то не то"); 
    return; 
}
else
{
    // int factorial = Factorial(number); 
    Console.WriteLine($"Факториал Вашего числа равен {Factorial(number)}"); 
}

void Test()

{
    int[] numbers = new int[] { 1, 2, 3, 4, 5 };
    int[] sums = new int[] { 1, 2, 6, 24, 120 };

    for (int i = 0; i < numbers.Length; i++)
    {
        int sum = Factorial(numbers[i]);

        if (sum != sums[i])
        {
            Console.WriteLine($"Oжидали получить {sums[i]}, а получили {sum}!");
        }
        else
        {
            Console.WriteLine("O`Kay");
        }
    }
}

int Factorial(int number)
{
    if ((number == 0) || (number == 1))
    {
        return 1;
    }
    return number * Factorial(number - 1);
}
