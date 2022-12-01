// Напишите программу, которая принимает на вход натуральное число N 
// и выдает таблицу кубов чисел от 1 до N

Console.Write("Введите натуральное число N => "); 

int numberN = InputNatural(); 

if (numberN > 0) 
{
    Console.WriteLine($"Вот как будет выглядеть последовательность кубов натуральных чисел от 1 до {numberN}: "); 
    PrintArray(GetArrayOfCubes(numberN)); 
}
else
{
   Console.WriteLine("То, что Вы ввели, не является натуральным числом"); 
   Console.WriteLine("Программа завершает свою работу."); 
}

void PrintArray (int[] array)
{
    int lastElement = array.Length-1; 
    for (int i = 0; i < lastElement; i++) 
    {
       Console.Write($"{array[i]}, "); 
    }
    Console.WriteLine(array[lastElement]);  
}

int InputNatural () 
{
    bool isNatural = int.TryParse(Console.ReadLine(), out int n); 
    if (!isNatural || n <= 0) 
    {
        return 0; 
    }
    else
    {
       return n;       
    }
}

int[] GetArrayOfCubes (int n)
{
    int[] array = new int[n]; 
    for (int j = 0; j < n; j++) 
    {
        array[j] = (int)Math.Pow(j+1, 3); 
    }    
    return array; 
}
