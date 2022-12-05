// Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве

Console.Write("Введите целое число => "); 

bool isInteger = int.TryParse(Console.ReadLine(), out int number);

int[] array = GenerateArray (-100, 100, 15); 

if (IsPresent(array, number)) 
{
    Console.WriteLine($"Число {number} содержится в сгенерированном массиве. "); 
}
else
{
    Console.WriteLine($"Числа {number} нет в сгенерированном нами массиве. "); 
}

if (!isInteger) 
{
    Console.WriteLine("То, что Вы ввели, не является целым числом!");
    return;  
}

bool IsPresent (int[] array, int numToFind) 
{
    bool result = false; 
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == numToFind) 
        {
            result = true; 
            break; 
        }
    }
    return result; 
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

