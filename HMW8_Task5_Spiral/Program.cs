// Заполните спирально массив 4х4

using static Common.Helper;

int numOfRowsInArray = 4;
int numOfColumnsInArray = 4;
int startMeaning = 1;

Console.WriteLine(string.Format("\n{0} {1} {2} {3} {4} {5}","Программа заполняет по спирали массив ", 
                numOfRowsInArray, "x", numOfColumnsInArray, 
                "последовательными целыми числами, начиная с ", startMeaning)); 

int[,] array = new int[numOfRowsInArray, numOfColumnsInArray];

// Print2DArray(array);

if (!FillArrayBySpiral(array, startMeaning))
{
     Console.WriteLine("Заданные параметры массива не позволили выполнить его спиральное заполнение. \n"); 
}
else
{
    Console.WriteLine("\nРЕЗУЛЬТАТ: \n"); 
    Print2DArray3Pos(array);
    Console.WriteLine(); 
}


bool FillArrayBySpiral(int[,] array, int startMeaning)
{
    int cycleCount = 0;
    int endMeaning = startMeaning;
    int startX = 0;
    int startY = 0;
    int numOfRows = array.GetLength(0);
    int numOfColumns = array.GetLength(1);

    while (FillFrameBySpiral(array, startMeaning, out endMeaning, startX, startY, numOfRows, numOfColumns))
    {

        cycleCount++;
        startMeaning = endMeaning;
        startX = startX + 1;
        startY = startY + 1;
        numOfRows = numOfRows - 2;
        numOfColumns = numOfColumns - 2;
    }
    return !(cycleCount == 0); 
    
}

// if (FillFrameBySpiral (array, startMeaning, out endMeaning, startX, startY, numOfRows, numOfColumns))
// {
//     Console.WriteLine(string.Format("Заполнили рамку на {0} строк и {1} столбцов, начиная с элемента [{2}, {3}]: \n", 
//                                     numOfRows, numOfColumns, startX, startY));
//     Print2DArray(array); 
//     Console.WriteLine($"\n Переменная endMeaning равна {endMeaning}"); 
// }
// else
// {
//     Console.WriteLine("Рамки с такими параметрами не существует в данном массиве. \n"); 
// }

bool FillFrameBySpiral(int[,] arr, int startMean, out int nextStartMean,
                            int startStrInd, int startColInd,
                            int numOfStrs, int numOfCols)    /* numOfStrs и numOfCols д.б. > 1 */
{
    nextStartMean = startMean;
    if (numOfStrs > 0 && numOfCols > 0 &&
        startStrInd >= 0 && startStrInd + numOfStrs - 1 < arr.GetLength(0) &&
        startColInd >= 0 && startColInd + numOfCols - 1 < arr.GetLength(1))
    {
        int mean = startMean;
        int i = startStrInd, j = startColInd;

        if (numOfStrs == 1 && numOfCols == 1)
        {
            arr[i, j] = mean;
            mean++;

            return true;
        }

        for (; j < startColInd + numOfCols - 1; j++)
        {
            arr[i, j] = mean;
            mean++;
        }
        // здесь у нас j = startColInd + numOfCols - 1; i = startStrInd; 

        for (; i < startStrInd + numOfStrs - 1; i++)
        {
            arr[i, j] = mean;
            mean++;
        }

        // здесь у нас j = startColInd + numOfCols - 1, i = startStrInd + numOfStrs - 1; 

        for (; j > startColInd; j--)
        {
            arr[i, j] = mean;
            mean++;
        }

        // здесь j = 0, i = startStrInd + numOfStrs - 1; 

        for (; i > startStrInd; i--)
        {
            arr[i, j] = mean;
            mean++;
        }

        // здесь j = 0, i = 0; 

        nextStartMean = mean;
        return true;
    }
    else
    {
        return false;
    }
}