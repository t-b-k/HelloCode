// Найдите сумму диагональных элементов массива nxn 

using static Common.Helper; 

int n = 5; 

double[,] ourArray = Create2DArray(n, n);

Print2DArray(ourArray); 

double sumOfDiagElements = SumOfDiagElements(ourArray); 

Console.WriteLine(sumOfDiagElements); 

double SumOfDiagElements (double[,] arr)
{
    double result = 0; 
    for (int i = 0; i < arr.GetLength(0); i++)
    {
       result = result + arr[i, i]; 
    }
    return result; 
}