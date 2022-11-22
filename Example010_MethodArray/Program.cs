// Имеется одномерный массив array из n элементов. 
// Требуется найти элемент массива, равный find

int[] array = {1, 12, 31, 4, 15, 23, 16, 15, 18}; 

int n = array.Length; 
int find = 15; 

int index = 0; 

while (index < n) 
{
    if (array[index] == find) 
    {
        Console.WriteLine(index); 
        break; 
    }
    index++; 
}