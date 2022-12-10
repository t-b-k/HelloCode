using static Common.Helper; 

// Не используя рекурсию, выведите на экран первые N 
// чисел Фибоначчи. Первые два числа равны 0 и 1. 

uint quantityOfFibonacciNumbers = 0; // В эту переменную будем считывать введенное пользователем N

if (!InputPositiveInteger("Укажите, какое количество чисел Фибоначчи "+
                          "Вы хотите увидеть => ", out quantityOfFibonacciNumbers))
{
    Console.WriteLine("Ошибка ввода. Программа завершает работу. \n");
    return;  
}

uint[] arrayOfFibonacciNumbers = new uint[quantityOfFibonacciNumbers]; 

FillArrayWithFibonacciNumbers(arrayOfFibonacciNumbers); 

Console.WriteLine($"{quantityOfFibonacciNumbers} первых чисел Фибоначчи выглядят так: \n");
Console.WriteLine(string.Join(" ", arrayOfFibonacciNumbers));  
Console.WriteLine(); 

void FillArrayWithFibonacciNumbers (uint[] array)
{
    int qty = array.Length; 
    array[0] = 0; 

    if (qty > 1) 
    {
        array[1] = 1; 
        for (int i = 2; i < qty; i++)
        {
        array[i] = array[i-2] + array[i-1]; 
        }
    }
}

