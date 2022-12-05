// Демонстрация решения
// Задача: задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9;9], 
// и найдите сумму отрицательных и положительных элементов массива. 

// Console.WriteLine("{0}, {1}, {2}, 1, 234, 1243"); 

int[] array = GenerateArray(-9,9,12); 
PrintArray(array);

int sumPositiveNumbers = GetSumPositiveNumbersInArray (array); 
int sumNegativeNumbers = GetSumNegativeNumbersInArray (array); 

void PrintArray (int[] array)
{
    // Console.WriteLine(@"[{0}]", string.Join(", ", array)); 
    
    string message = string.Join(", ", array); 
    Console.WriteLine($"[{message}]"); 
}

int GetSumPositiveNumbersInArray (int[] array)
{
    int sumPositiveNumbers = 0; 
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) 
        {
            sumPositiveNumbers += array[i]; 
        }
    }
    return sumPositiveNumbers; 
}

int GetSumNegativeNumbersInArray (int[] array)
{
    int sumNegativeNumbers = 0; 
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) 
        {
            sumNegativeNumbers += array[i]; 
        }
    }
    return sumNegativeNumbers; 
}

int[] GenerateArray (int min, int max, int length)
{
    Random random = new Random(); 
    int[] array = new int[length]; 

    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(min, max+1); 
    }

    return array; 
}

// Метод Contains: ищет число в массиве