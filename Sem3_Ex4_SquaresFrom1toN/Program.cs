// Напишите программу, которая принимает на вход число N
// и выдает таблицу квадратов чисел от 1 до N

int num = InputInt();
int[] squaresTable = GetSquaresTable (num);
PrintArray(squaresTable); 


int InputInt () 
{
    Console.WriteLine("Введите целое число");
    bool isNum = int.TryParse(Console.ReadLine(), out int num); 
    if (isNum) 
    {
        return num; 
    } 
    else
    {
        Console.WriteLine("Вы ввели некорректное значение"); 
        return -1; 
    }
}

int[] GetSquaresTable (int num) 
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++) 
    {
        array[i] = (int)((Math.Pow(i+1,2)));
    } 
    return array; 
}

void PrintArray (int[] arr) 
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} "); 
    }
    Console.WriteLine();
}
