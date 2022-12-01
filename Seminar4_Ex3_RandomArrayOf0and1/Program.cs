// Напишите программу, которая выводит массив из 8-ми элементов
// заполненный нулями и единицами в случайном порядке

Random random = new Random();

bool isInt = int.TryParse(Console.ReadLine(), out int num);

if (!isInt)
{
    Console.WriteLine("То, что Вы ввели, не является целым числом!");
}
else
{
    int[] array = ArrayFilling(num);

    test(array, num); 

    // PrintArray(array);

    int[] ArrayFilling(int userLength)
    {
        int[] arr = new int[userLength];
        for (int i = 0; i < userLength; i++)
        {
            arr[i] = random.Next(0, 2);
        }
        return arr;
    }

    // void PrintArray(int[] arr)
    // {
    //     int j = 0;
    //     for (; j < arr.Length - 1; j++)
    //     {
    //         Console.Write($"{arr[j]}, ");
    //     }
    //     Console.WriteLine(arr[j]);
    // }
}

void test(int[] userArray, int enteredNumber)
{
    if (userArray.Length != enteredNumber)
    {
        Console.WriteLine("Длина созданного массива не совпадает с длиной, заданной пользователем");
    }
    else
    {
        Console.WriteLine("Создался массив правильной длины");
    }
}