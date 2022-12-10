// Задайте массив вещественных чисел
// Найдите разницу между максимальным и минимальным элементами массива

Console.WriteLine("Введите исходные данные: \n"); 
Console.Write("Введите длину массива, с которым будем работать (должна быть больше 1) => ");  

int length = 0; 

if (!CorrectInputOfArrayLength (out length))
{
    Console.WriteLine("\nВведенное Вами значение не может являться длиной массива! \nПрограмма завершает свою работу. \n");
    return; 
}
Console.WriteLine(); 

double[] array = new double[length]; 

if (CorrectInputOfArray(array)) 
{
    double diff = MaxInArray(array) - MinInArray(array); 
    Console.WriteLine("\nРЕЗУЛЬТАТ: В заданном Вами массиве - \n"); 
    PrintDoubleArray(array); 
    Console.WriteLine($"- разница между максимальным и минимальным элементами составляет {diff}.\n"); 
}
else
{
    Console.WriteLine("Сожалеем, но Вы не справились с вводом исходных данных ((\n"); 
}

bool CorrectInputOfArrayLength (out int size) 
{
    size = 0; 
    bool lengthCorrect = false; 
    if (int.TryParse(Console.ReadLine(), out int length) && length > 1) 
    {
        lengthCorrect = true; 
        size = length;   
    }
    
    return lengthCorrect; 
}

void PrintDoubleArray (double[] array)
{
    Console.WriteLine("["+string.Join("; ", array)+"]\n"); 
}

bool CorrectInputOfArray (double[] arr)
{
    bool result = true; 
    for (int count = 0; count < arr.Length; count++)
    {
        Console.Write($"Введите {count+1}-й элемент => "); 
        if (double.TryParse(Console.ReadLine(), out double number)) 
        {
            arr[count] = number; 
        }
        else
        {
            Console.WriteLine("Это не вещественное число. \n"); 
            result = false; 
            break; 
        }
    }
    return result; 
}

double MaxInArray (double[] arr)
{
    double max = arr[0]; 
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i]; 
    }
    return max; 
}

double MinInArray (double[] arr)
{
    double min = arr[0]; 
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i]; 
    }
    return min; 
}