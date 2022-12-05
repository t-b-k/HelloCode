// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем симметричные элементы массива. 
// Результат записать в новый массив

int[] array = GenerateArray (-10, 10, 7); 

PrintArray(array); 

int[] newArray = SymmElementsProducts (array); 

PrintArray(newArray);

int[] SymmElementsProducts (int[] arr)
{
    int newArrayLength = arr.Length/2; 
    if (arr.Length%2 !=0) newArrayLength++; 
    
    int[] newArray = new int[newArrayLength]; 
    
    int i; 
    for (i = 0; i < newArrayLength-1; i++)
    {
        newArray[i] = arr[i]*arr[arr.Length-1-i]; 
    }
    if (arr.Length%2 == 0) 
    {
        newArray[i] = arr[i]*arr[arr.Length-1-i];
    }
    else
    {
        newArray[i] = arr[i]; 
    }
    return newArray; 
}

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