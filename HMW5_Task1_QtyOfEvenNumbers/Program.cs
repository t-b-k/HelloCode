// Задайте массив, заполненный случайными положительными 3-значными числами. 
// Напишите программу, которая покажет количество четных чисел в массиве

int min = 100; 
int max = 999; 
int length = 20; 

int[] array = GenerateArray (min, max, length); 

Console.WriteLine($"Сгенерирован массив из {length} чисел в диапазоне [{min}, {max}]: "); 
Console.WriteLine(); 
PrintArray(array); 
Console.WriteLine(); 

int numberOfEven = QtyOfEvens(array); 

Console.WriteLine($"В данном массиве четных чисел:  {numberOfEven}\n"); 

void PrintArray (int[] arr)
{
    Console.WriteLine("["+string.Join(", ", arr)+"]"); 
}

int QtyOfEvens (int[] arr)
{
    int qty = 0; 
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) 
        {
            qty = qty + 1;
        }
    }
    return qty; 
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
