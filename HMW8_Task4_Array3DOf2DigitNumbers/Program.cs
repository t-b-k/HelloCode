// Сформируйте 3-мерный массив из неповторяющихся 2-значных чисел. 
// Напишите программу, которая будет построчно выводить массис, 
// добавляя индексы каждого элемента

using static Common.Helper; 

Console.ForegroundColor = ConsoleColor.Yellow; 
Console.WriteLine("\nЗАДАЧА: Заполнить случайный 3-мерный массив неповторяющимися 2-значными числами.\n"); 
Console.ResetColor(); 

Console.WriteLine("Чтобы задача была выполнима, произведение размерностей массива не должно превосходить 90. \n"); 

// Неповторяющихся двузначных чисел всего 90, 
// поэтому произведение размерностей 3-мерного массива не должно превышать этого значения: 
int limitOfHeight = 4;
int limitOfWidth = 4; 
int limitOfDepth = 5; 

Console.WriteLine("Поэтому мы сгенерируем массив, в котором: "); 
Console.WriteLine("{0}, \n{1}, \n{2}.", 
                    $"число строк не превышает {limitOfHeight}", 
                    $"число столбцов не превышает {limitOfWidth}", 
                    $"число слоев не превышает {limitOfDepth}"); 

Random random = new Random(); 
int qtyOfRows = random.Next(2, limitOfHeight+1);
int qtyOfColumns = random.Next(2, limitOfWidth+1); 
int qtyOfLayers = random.Next(2, limitOfDepth+1);

// С учетом указанных выше ограничений создаем 3D-массив и заполняем его нулями.  

int[,,] array3D = new int[qtyOfRows, qtyOfColumns, qtyOfLayers]; 

// В массиве arrayOfMeanings создаем набор неповторяющихся случайных 2-значных чисел, 
// которыми будем заполнять наш 3-мерный массив

int[] arrayOfMeanings = new int[qtyOfRows * qtyOfColumns * qtyOfLayers]; 
FillArrayWith2DigitRandomNUmbers (arrayOfMeanings); 

Fill3DArrayWithRandom2DigitNumbers(array3D, arrayOfMeanings); 

// Распечатаем результат по слоям: 

Console.ForegroundColor = ConsoleColor.Blue; 
Console.WriteLine("\nПолученный массив выведем на экран по слоям: "); 

Print3DArrayOf2DigitIntegers(array3D); 
Console.WriteLine(); 
Console.ResetColor(); 

/*********************************************************************************/

void Print3DArrayOf2DigitIntegers (int[,,] arr)
{
    for (int k = 0; k < arr.GetLength(2); k++) 
    {
        Console.WriteLine(); 
        for (int i = 0; i < arr.GetLength(0); i++) 
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"({i},{j},{k}): {arr[i,j,k],-4}  "); 
            }
            Console.WriteLine(); 
        }
    }
}


void Fill3DArrayWithRandom2DigitNumbers (int[,,] arr, int[] numbers)
{
    int numbersCount = 0; 
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i,j,k] = numbers[numbersCount]; 
                numbersCount++; 
            }
        }
    }
}

// Массив случайных значений для заполнения нашего 3-мерного друга
// При инициализации передаваемый на заполнение массив был заполнен нулями, 
// поэтому при геренации ложных случайных совпадений не возникнет

void FillArrayWith2DigitRandomNUmbers (int[] arr)
{
    Random gen = new Random(); 
    int nextNumber = 0; 
    for (int i = 0; i < arr.Length; i++)
    {
        nextNumber = gen.Next(10,100); 
        while (Present(arr, nextNumber))
        {
            nextNumber = gen.Next(10,100); 
        }
        arr[i] = nextNumber; 
    }    
}

// Метод проверяет, присутствует  ли в заданном массиве заданное число

bool Present (int[] arr, int value)
{
    bool result = false; 

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == value)
        {
            result = true; 
            break; 
        }
    }
    return result; 
} 

