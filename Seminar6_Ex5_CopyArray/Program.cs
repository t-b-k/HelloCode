using static Common.Helper; 

// Напишите программу, которая создает копию заданного 
// массива с помощью поэлементного копирования

int[] array = new int[]{1,3,4,5,3,7,7,4,565,4}; 

PrintArray(array);
Console.WriteLine(); 

int length = array.Length; 

int[] duplicatedArray = new int[length]; 

for (int i = 0; i <= length - 1; i++) 
{
    duplicatedArray[i] = array[i]; 
}

Console.WriteLine("\nКопия выглядит так: \n");
PrintArray(duplicatedArray);



