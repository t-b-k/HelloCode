// виды методов

// Тип 1: метод, который ничего не принимает и ничего не возвращает

void Method1 ()
{
    Console.WriteLine("Автор ... "); 
}

// Вызов такого метода: 

Method1();   // Точка с запятой обязательны

// Тип 2: Метод, который что-то принимает и ничего не возвращает

void Method2 (string msg)
{
    Console.WriteLine(msg); 
}

// Вызов такого метода: 

Method2(msg: "Текст сообщения"); 

void Method21 (string msg, int count)
{
    int i = 0; 
    while (i < count) 
    {
        Console.WriteLine(msg); 
        i++; 
    }
}

// Вызов: 

Method21 (count: 4, msg: "ТЕКСТ"); 

// Тип 3: Ничего не принимает, но что-то возвращает. 

int Method3 ()
{
    return DateTime.Now.Year; 
}

// Вызов: 

int year = Method3(); 
Console.WriteLine(year);

// Тип 4: и принимает, и возвращает

string Method4 (int count, string text)
{
    int i = 0; 
    string result = string.Empty; 

    while (i < count)
    {
        result = result + text; 
        i++; 
    }
    return result; 
}

// Вызов: 

string res = Method4 (10, "asdf");
Console.WriteLine(res);

// Цикл в цикле - вывод таблицы умножения на экран

for (int i = 2; i <=10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}"); 
    }
    Console.WriteLine(); 
}

// Работа с текстом
// Дан текст. В нем нужно все пробелы заменить подчеркиваниями, 
// маленькие буквы "к" заменить большими "К", 
// а большие буквы "С" заменить маленькими - "с". 

string text = "Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо вашего милого Винценгероде, " 
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?"; 

// Строка представляет собой массив символов. 
// Обратиться к конкретному символу строки можно по индексу. 
// Индексация начинается с нуля. 

string Replace (string text, char oldValue, char newValue)
{
    string result = String.Empty; 

    int length = text.Length; 
    for (int i = 0; i< length; i++) 
    {
        if (text[i] == oldValue) result = result + $"{newValue}"; 
        else result = result + $"{text[i]}"; 
    }
    return result; 
}

string newText = Replace(text, ' ', '_'); 
Console.WriteLine(newText);
Console.WriteLine(); 
newText = Replace(newText, 'k', 'K');   // Русские буквы
newText = Replace(newText, 'к', 'К');   // Латинские буквы  
Console.WriteLine(newText); 
Console.WriteLine(); 
newText = Replace(newText, 'С', 'с');   // Русские буквы
newText = Replace(newText, 'C', 'c');   // Латинские буквы  
Console.WriteLine(newText); 
Console.WriteLine(); 

// Алгоритм сортировки методом выбора (или методом "минимакса")

//  1. Найти позицию минимального элемента в неотсортированной части массива
//  2. Произвести обмен этого значения со значением первого из  неотсортированных элементов
//  3. Повторять до тех пор, пока остаются неотсортированные элементы

int[] arr = {1,5,4,3,2,6,7,1,1}; 

void PrintArray (int[] array)
{
    int count = array.Length; 
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} "); 
    }
    Console.WriteLine(); 
}

PrintArray(arr);
SelectionSort(arr); 
PrintArray(arr);

void SelectionSort (int[] array)
{
    for (int i = 0; i < array.Length-1; i++) 
    {
        int minPosition = i; 

        for (int j = i+1; j < array.Length; j++) 
        {
            if (array[j] < array[minPosition]) minPosition = j; 
        }

        int temporary = array[i]; 
        array[i] = array[minPosition]; 
        array[minPosition] = temporary; 
    }
}




