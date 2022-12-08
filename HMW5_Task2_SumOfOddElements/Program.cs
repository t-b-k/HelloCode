// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму его елементов, стоящих на позициях с нечетными индексами (2-й + 4-й +... )

int upperBound = 110;
int lowerBound = -110;

int arrayLength = 10;

int[] array = generateArray(lowerBound, upperBound, arrayLength);

Console.WriteLine("Сгенерирован массив: \n"); 
PrintArray(array);

double sumOfElementsWithOddIndexes = SumOfElementsWithOddIndexes(array); 

Console.WriteLine($"Сумма элементов сгенерированного массива с нечетными индексами равна {sumOfElementsWithOddIndexes}\n"); 

double SumOfElementsWithOddIndexes(int[] arr)
{
    double result = 0; 
    for (int i = 1; i < arr.Length; i = i+2)
    {
        result = result + arr[i]; 
    }
    return result; 
}

int[] generateArray(int minValue, int maxValue, int length)
{
    Random random = new Random();
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = random.Next(minValue, maxValue);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.WriteLine();
    Console.WriteLine("[" + string.Join(", ", arr) + "]\n");
}

