// Напишите программу замены элементов массива: 
// положительные замените на отрицательные и наоборот

int[] initialArray = GenerateArray(-10, 10, 10); 

PrintArray(initialArray); 

int[] resultArray = PosNegExchange (initialArray);

PrintArray(resultArray); 

void PrintArray (int[] array)
{
    Console.WriteLine(string.Join(", ", array)); 
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

int[] PosNegExchange (int[] array)
{
    // int length = array.Length; 
    int[] arr = new int[array.Length]; 

    for (int i=0; i < array.Length; i++)
    {
            arr[i] = -array[i]; 
    }
    return arr; 
}
