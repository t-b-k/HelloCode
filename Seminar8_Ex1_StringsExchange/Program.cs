// 
using static Common.Helper; 

int numberOfRows = 5; 
int numberOfColumns = 7; 

int[,] array = CreateRandomArray(numberOfRows, numberOfColumns); 

Print2DArray(array); 
Console.WriteLine(); 

int[,] resultArray = FirstLastStringsChange(array); 

Print2DArray(resultArray); 
Console.WriteLine(); 

int[,] FirstLastStringsChange (int[,] array)
{
    int rowNumber = array.GetLength(0); 
    int columnNumber = array.GetLength(1); 

    int[,] result = Copy2DArray(array);

    for (int i = 0; i < columnNumber; i++)
    {
        result[0,i] = array[rowNumber-1,i]; 
        result[rowNumber-1,i] = array[0,i]; 
    } 
    return result; 
}

int[,] Copy2DArray (int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)]; 

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for ( int j = 0; j < array.GetLength(1); j++)
        {
            result[i,j] = array[i,j]; 
        }
    }
    return result; 
}

