// Написать программу, которая подсчитывает количество 
// положительных среди N чисел, введенных пользователем

using static Common.Helper; 

int N = 3; 

Console.WriteLine($"\nВведите {N} целых числа(ел). \n"+
                   "Программа посчитает, сколько среди них положительных. \n"); 

int qtyOfPositive = 0; 
int n = 0; 
int count = 0; 

for (count = 1; count <= N; count++)
{
    if (!InputInteger($"Введите {count}-е число => ", out n))
    {
        Console.WriteLine($"То, что Вы ввели, не является целым числом. Программа завершает свою работу. \n"); 
        break; 
    }
    else
    {
        if (n > 0) 
        {
            qtyOfPositive++; 
        }
    }
}

if (count > N) 
{
   Console.WriteLine($"\nРЕЗУЛЬТАТ:\tСреди введенных Вами целых чисел положительных - {qtyOfPositive}\n");
   
}

// Здесь в качестве комментария я даю описание метода InputInteger, 
// чтобы проверяющему было понятно, как он работает
//
// bool InputInteger (string text, out int number)
// {
//    Console.Write(text); 
//    return int.TryParse(Console.ReadLine(), out number); 
// } 

