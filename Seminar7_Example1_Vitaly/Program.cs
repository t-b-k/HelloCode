// using static Common.Helper

// Задайте двумерный массив размера m x n, 
// заполненный целыми числами
// m = 4. n = 4
// 1 4 8 19

// int[,] array = CreateRandomArray (3,4); 
// Print2DArray(array); 

int[,] CreateRandomArray (int countOfRows, int countOfColumns) 
{
    CreateRandomArray random
    int[,] array = new int[countOfRows, countOfColumns];  

    for (var i = 0; i < array.GetLength(0); i++) 
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = CreateRandomArray.Next(-10, 11); 
        }
    }
} 

void Print2DArray (int[,] array)
for (var i = 0; i < array.GetLength(0); i++) 
{
    for (var j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i,j]} "); 
    }
}

// КОРТЕЖИ. 

// GetSomething(); 

// int[] GetSomething()
// {
//     int a = 5; 
//     int b = 6; 

//     int[] array = new int[2]; 
//     array[0] = a; 
//     array[1] = b; 
//     return array; 
// }

// (int,int) coordinates = GetSomething(); 

// Console.WriteLine(coordinates.Item1); 
// Console.WriteLine(coordinates.Item2);

// (int,int) GetSomething()
// {
//     int a = 5; 
//     int b = 6; 

//     return (a,b); 
// }

// string - СТРОКИ
// Для них есть очень много методов

// int[] array = new int[3]{1,3,4}; 

// string.Join(",", array); // любой массив, список и т.д. можно собрать с пом. него в одну строчку

// string.Format("{0}   {1}   {2}", <выр-е_0>, <выр-е_1>, <выр-е_2>); // Если мы хотим 
//                                     // в какую-то строчку встроить значения
//                                     // В фигурных строках указываются номера аргументов

// string.Concat("", "");  // тоже сложение строк

// string.Empty; 
// string.IsNullOrEmpty; 
// string.IsNullOrWhiteSpace; 
// string.Compare(string str1, string str2);  

// str2.EndsWith("123");
// str2.StartsWith("123");
// str2.Contains("2134");   
// str.Distinct(); // Убирает все повторения, кроме 1-го
// str.Remove (<Индес, с которого начинаем удаление>, <Сколько элементов удаляем>)
// str.Trim() // Убирает пустые символы



