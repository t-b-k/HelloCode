// Как создать библиотеку методов и пользоватьмся ими постоянно

// using static Common;

// Теперь можно использовать методы из папки Common, обращаясь к ним по имени файла, 
// в котором они прописаны: 
// Пример: TatKa.CreateRandomArray(); 

// а можно сделать так: 

// using static Common.TatKa; 

// и тогда можно не добавлять каждый раз к имени метода название класса TatKa
// и писать просто: CreateRandomArray(); 
// и метод CreateRandomArray будет виден, несмотря на то, что он определен в другой папке. 

using static Common.Helper; 

// Задача 39: Напишите программу, которая перевернет одномерный массив 
// (последний элемент будет стоять на первом месте, а поледний - на первом)

Console.WriteLine (int.MaxValue); 
int[] array = CreateRandomArray(); 
PrintArray(array); 
Console.WriteLine(); 

int[] reversed = ReverseArray(array); 
PrintArray(reversed); 

int[] ReverseArray (int[] array)
{
    int[] reversedArray = new int[array.Length]; 

    for (var i = 0; i < array.Length; i++)
    {
        reversedArray[i] = array[array.Length-1-i]; 
    }
    return reversedArray; 
}


