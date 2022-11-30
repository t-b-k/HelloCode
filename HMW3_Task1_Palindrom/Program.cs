// Напишите программу, которая принимает на вход целое неотрицательное число
// и проверяет, является ли оно палиндромом

Console.WriteLine("Введите любое целое неотрицательное целое число. ");
Console.Write("Проверим, является ли оно палиндромом => ");

int num = InputPositiveInt();     // Считываем только целые неотрицательные числа. Иначе возвращаем -1. 

if (num >= 10)                     // Что делать с числами из одной цифры, пусть решает сам пользователь
{
    int[] arr = CreateArrayByNumber(num);

    if (Palindrom(arr))
    {
        Console.WriteLine("Введенное Вами число является палиндромом! ");
    }
    else
    {
        Console.WriteLine("Введенное Вами число не является палиндромом! ");
    }

}
else
{
    if (num >= 0)
    {
        Console.WriteLine("Вы ввели однозначное число. Считать ли такое число палиндромом, решайте сами.");
    }
    else 
    {
        Console.WriteLine("То, что Вы ввели, не является неотрицательным целым числом. ");
    }
}



// Метод InputPositiveNumber cчитывает то, что ввел пользователь. 
// Если это не целое число или если это отрицательное число, укажем на ошибку и выдадим -1. 
// Иначе возвратим введенное пользователем число. 

int InputPositiveInt()
{
    bool PositiveInt = int.TryParse(Console.ReadLine(), out int number);

    if (!PositiveInt || number < 0)
    {
        return -1;
    }
    else
    {
        return number;
    }
}

// Метод NumberOfDigits возвращает количество цифр в целом неотрицательном числе. 
// Если число отрицательное, метод возвращает 0

int NumberOfDigits(int num)
{
    int count = 0;
    if (num >= 0)
    {
        count = 1;
        while (num > 9)
        {
            num = num / 10;
            count++;
        }
    }
    return count;
}

// Метод CreateArrayByNumber получает на вход целое неотрицательное число, 
// и формирует массив из составляющих его цифр

int[] CreateArrayByNumber(int number)
{
    int size = NumberOfDigits(number);
    int[] array = new int[size];

    int index = size - 1;
    int quotient = number;    // Не будем изменять заданное число. Заведем для этих целей вспомогательную переменную

    while (quotient > 0)
    {
        array[index] = quotient % 10;
        quotient = quotient / 10;
        index--;
    }

    return array;
}

// Метод Palindrom возвращает логическое значение, равное
// true - если поступивший на вход массив является симметричным относительно середины, 
// false - в противном случае. 

bool Palindrom (int[] array)
{
    bool result = true;
    int numberOfElements = array.Length;
    int middleElementIndex = (array.Length - 1) / 2;
    for (int index = 0; index < middleElementIndex; index++)
    {
        if (array[index] != array[numberOfElements - 1 - index])
        {
            result = false;
            break;
        }
    }
    return result;
}