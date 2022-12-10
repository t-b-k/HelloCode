using static Common.Helper; 

// Напишите программу, которая будет преобразовывать 
// целое положительное десятичное число в двоичное

uint decNumber = 0; 

if (!InputPositiveInteger("Введите целое положительное число => ", out decNumber)) 
{
    Console.WriteLine("\nОшибка ввода. Программа завершает свою работу. \n");
    return;  
}

uint binArrayLength = numberOfBinRanges(decNumber);  

Console.WriteLine("Двоичная запись введенного Вами числа будет выглядеть так: \n"); 
Console.WriteLine(string.Join("",CreateBinArrayFromDecimalNumber(decNumber))); 

uint[] CreateBinArrayFromDecimalNumber (uint number)
{
    uint arrayLength = numberOfBinRanges(number); 
    uint[] binNumberArray = new uint[arrayLength]; 

    for (int i = (int)arrayLength-1; i >= 0; i--)
    {
        binNumberArray[i] = number % 2; 
        number = number / 2; 
    }
    return binNumberArray; 
}

void PrintBinDigitsArray (uint[] binArray)
{
    Console.WriteLine(); 
    for (int i = 0; i < binArray.Length; i++) 
    {
        Console.Write(binArray[i]); 
    }
    Console.WriteLine(); 
} 

uint numberOfBinRanges (uint decNumber) 
{
    uint res = 1;  
    decNumber = decNumber / 2; 

    while (decNumber > 0) 
    {
        res++; 
        decNumber = decNumber / 2; 
    }
    return res; 
}
