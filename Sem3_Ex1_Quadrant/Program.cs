// Напишите программу, которая принимает на вход координаты
// точки (X, Y), причем X<>0 и Y<>0, и выдает номер четверти
// в которой находится эта точка

bool isParsedX = int.TryParse(Console.ReadLine(), out int x); 
bool isParsedY = int.TryParse(Console.ReadLine(), out int y); 

if (!isParsedX || !isParsedY)  
{
    Console.WriteLine("Координаты введены некорректно"); 
    return;
}

// возвращаемый_тип_данных НазваниеМетода()

int GetQuarterNumberByCoordinates (int x, int y)
{
    if (x > 0 && y > 0) 
    {
        return 1;
    }

    if (x < 0 && y > 0) 
    {
        return 2; 
    }

    if (x < 0 && y < 0) 
    {
        return 3;
    }

    if (x > 0 && y < 0) 
    {
        return 4; 
    }

return -1; 

}

int quarterNumber = GetQuarterNumberByCoordinates (x,y); 

if (quarterNumber == -1) 
{
    Console.WriteLine("Координаты введены некорректно");
    return;  
} 

Console.WriteLine(quarterNumber); 

void PrintArray (int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.WriteLine(array[i]); 
    }
}