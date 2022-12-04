// Программа предлагает пользователю ввести размер массива 
// и числа, которыми его надо заполнить. 
// Заполняет массив этими числами и выводит его на экран

int arrayLength = 0; 

if (GetArrayLength (out arrayLength))
{
    Console.WriteLine ($"Вы ввели длину массива, равную {arrayLength}"); 
}
else 
{
    Console.WriteLine($"То, что Вы ввели, не может являться длиной массива. \nПрограмма завершает работу."); 
    return; 
}

// Console.WriteLine(arrayLength); 

int[] ourArray = new int[arrayLength]; 

// PrintArray(ourArray); 

if (GetArrayElements(ourArray)) 
{
    PrintArray(ourArray); 
}
else
{
    Console.WriteLine($"Сожалеем, но Вы не справились cо вводом {arrayLength} целых чисел.\n Программа завершает рабооту. "); 
}

bool GetArrayElements (int[] array)
{
    int qtyOfElements = array.Length; 
    Console.WriteLine($"Введите значения для элементов массива из {qtyOfElements} элементов => "); 

    int j; 
    bool isInt = true; 
    for (j = 0; j < qtyOfElements && isInt; j++) 
    {
        Console.Write($"Введите значение {j+1}-го элемента: "); 
        isInt = int.TryParse(Console.ReadLine(), out int number); 
        if (isInt) 
        {
            array[j] = number; 
        } 
        else break; 
    }
    return isInt; 
}

void PrintArray (int[] array)
{
    int i = 0; 
    Console.WriteLine("Вот как выглядит Ваш массив: "); 
    Console.Write($"[{array[i]}"); 
    for (i++; i < array.Length; i++)
    {
        Console.Write($", {array[i]}"); 
    }
    Console.WriteLine("]"); 
}

bool GetArrayLength(out int length)
{
    Console.Write("Введите длину массива => ");
    if (int.TryParse(Console.ReadLine(), out int l) && l > 0)
    {
        length = l;
        return true; 
    }
    else 
    {
        length = 0; 
        return false; 
    }
}
