// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных 

using static Common.Helper; 

int numberOfRows = 0; 
int numberOfColumns = 0; 
uint maxRows = 10; 
uint maxColumns = 10; 
int minValue = -10; 
int maxValue = 11; 

int[,] array = CreateRandom2DArray(out numberOfRows, out numberOfColumns,
                                            maxRows, maxColumns,
                                            minValue, maxValue); 

Print2DArray(array); 

int numberOfDifValues = qtyOfDifElements(array); 

Console.WriteLine(numberOfDifValues); 

int[,] freqDict = new int[2,numberOfDifValues]; 

int qtyOfDifElements(int[,] arr)
{
    int count = 0; 
    for (int i = 0; i < arr.GetLength(0); i++)
    {        
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            bool coincid = false; 
            for (int k = 0; k < i; k++) 
            {
                for (int l = 0; l < arr.GetLength(1); l++) 
                {
                        coincid = coincid || (arr[k,l] == arr[i,j]); 
                    
                }
            }
            for (int m = 0; m < j; m++)
            {
                coincid = coincid || arr[i,m] == arr[i,j]; 
            }
            if (!coincid) count++;  
        }
    }
    return count; 
}

bool Found (int number, int[] array)
{
    bool res = false; 
    for (int i = 0; i < array.Length; i++) 
    {
        res = res || (array[i] == number); 
    }
    return res; 
}

int[,] FreqDictionary (int[,] arr)
{
    int numberOfDifValues = qtyOfDifElements(arr); 

    int[,] freqDict = new int[2,numberOfDifValues]; 
 
    for (int i = 0; i < arr.GetLength(0); i++)
    {        
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            bool coincid = false; 
            for (int k = 0; k < i; k++) 
            {
                for (int l = 0; l < arr.GetLength(1); l++) 
                {
                        coincid = coincid || (arr[k,l] == arr[i,j]); 
                    
                }
            }
            for (int m = 0; m < j; m++)
            {
                coincid = coincid || arr[i,m] == arr[i,j]; 
            }
            if (!coincid) count++;  
        }
    }
    return count; 
}

