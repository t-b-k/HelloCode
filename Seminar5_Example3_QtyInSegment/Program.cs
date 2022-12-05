// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат на отрезке [10, 99]

int[] array = GenerateArray (-100, 100, 123); 

PrintArray(array); 

int min = 10; 
int max = 99; 
int result = FindAllElementsInSegment (array, min, max); 

Console.WriteLine($"Кол-во элементов массива, лежащих на отрезке [{min}; {max}] равно {result}."); 

int FindAllElementsInSegment (int[] array, int min, int max)
{
    int quantity = 0; 
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] >= min && array[i] <= max) quantity++; 
    }
    return quantity; 
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

void PrintArray (int[] array)
{
    Console.WriteLine(string.Join(", ", array)); 
}
