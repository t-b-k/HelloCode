// Напишите программу, которая по заданному номеру четверти 
// показывает диапазон возможных координат точек в этой четверти (x,y)

// using static Console; 

Console.WriteLine("Введите номер квадранта =>"); 

bool isParsed = int.TryParse(Console.ReadLine(), out int quarterNumber); 

if (!isParsed || quarterNumber < 0 || quarterNumber > 4)  
{
    Console.WriteLine("Координаты введены некорректно"); 
    return;
}

// возвращаемый_тип_данных НазваниеМетода()

string QuadrantParameters (int quadNum)
{
    if (quadNum == 1)
    {
        return("x > 0 && y > 0"); 
    } 

    if (quadNum == 2)
    {
        return("x < 0 && y > 0"); 
    } 

    if (quadNum == 3) 
    {
        return("x < 0 && y < 0"); 
    }

    if (quadNum == 4)
    {
        return("x > 0 && y < 0"); 
    }

    return("Координаты введены некорректно"); 
}

Console.WriteLine(QuadrantParameters(quarterNumber)); 

