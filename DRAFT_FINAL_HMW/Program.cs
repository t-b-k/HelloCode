// Программа из предложенного пользователем массива строк выбирает строки 
// длиной 3 символа и заносит их в отдельный массив

using static Common.Helper;

// Длину массива будем формировать случайным образом путем генерации случайных чисел 
// из диапазона [2;10]

Random random = new Random();

int arrayLength = random.Next(2, 11);
uint numberOfSymbols = 3;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"\nВведите {arrayLength} строк. \n");
Console.WriteLine("Программа сформирует массив из тех из них, которые состоят из 3-х символов");
Console.WriteLine("И выведет этот массив на экран. \n");

string nextString = string.Empty;

string[] array = new string[arrayLength];

Console.ForegroundColor = ConsoleColor.Blue;

for (int i = 0; i < arrayLength; i++)
{
    if (InputString($"Введите {i + 1}-ю строку => ", out nextString))
    {
        array[i] = nextString;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Сожалеем, но Вы не справились с задачей ввода строк. ");
        Console.WriteLine("Программа завершает работу. \n");
        Console.ResetColor();
        return;
    }
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nВот какой массив Вы ввели: \n");

PrintArrayOfStrings(array, ",");
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("РЕЗУЛЬТАТ:");

string[] resultArray = GetStringsNotLongerThan (array, numberOfSymbols); 

Console.ForegroundColor = ConsoleColor.Yellow;

if (resultArray == null) 
{
    Console.WriteLine("{0} {1}", "\tСреди введенных Вами строк",
                        $"нет строк длиной не более {numberOfSymbols} символ(а)(ов). \n");
    Console.ResetColor();
    return;
}
else
{
    Console.WriteLine("{0} {1}", "\tСреди введенных Вами строк",
                    $"{resultArray.Length} строк(и) длиной не более {numberOfSymbols} символ(а)(ов).");
    Console.WriteLine("\tВот результирующий массив: \n");
    Console.Write("\t");
    PrintArrayOfStrings(resultArray, ", ");
}

Console.WriteLine();
Console.ResetColor();

void PrintArrayOfStrings(string[] arr, string separator)
{
    int i = 0;
    Console.Write("[");
    for (; i < arr.Length - 1; i++)
    {
        Console.Write("{0}{1}{2}", "\"", arr[i], "\"");
        Console.Write(separator);
    }
    Console.WriteLine("{0}{1}{2}{3}", "\"", arr[i], "\"", "]");
}

bool InputString(string invit, out string nextString)
{
    Console.Write(invit);

    string? inputStr = Console.ReadLine();
    bool isStrNullOrEmpty = String.IsNullOrEmpty(inputStr);
    if (isStrNullOrEmpty)
    {
        nextString = String.Empty;
    }
    else
    {
        nextString = inputStr;
    }
    return !isStrNullOrEmpty;
}

int QtyOfStringsNotLongerThan(string[] arr, uint length)
{
    int qtyOfStrings = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= length)
        {
            qtyOfStrings = qtyOfStrings + 1;
        }
    }
    return qtyOfStrings;
}

string[] GetStringsNotLongerThan(string[] arr, uint maxLength)
{
    int resultArrayLength = QtyOfStringsNotLongerThan(arr, maxLength);

    if (resultArrayLength == 0) return null;
    else
    {
        string[] resultArray = new string[resultArrayLength];
        for (int i = 0, j = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= maxLength)
            {
                resultArray[j] = arr[i];
                j++;
            }
        }
        return resultArray; 
    }
}