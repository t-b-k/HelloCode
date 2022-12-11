// Программа находит точку пересечения двух прямых, заданных 
// уравнениями y = k1*x+b1, y - k2*x+b2
// k1, b1, k2 и b2 задаются пользователем

using static Common.Helper; 

double k1; 
double b1; 
double k2; 
double b2; 

Console.WriteLine("\nВведите параметры двух прямых, точку пересечения которых Вы хотите найти. \n");

if (InputDouble("Введите коэффициент угла наклона 1-й прямой k1 => ", out k1) && 
    InputDouble("Введите смещение 1-й прямой по оси ординат  b1 => ", out b1) &&
    InputDouble("Введите коэффициент угла наклона 1-й прямой k2 => ", out k2) && 
    InputDouble("Введите смещение 1-й прямой по оси ординат  b2 => ", out b2)) 
{
     Console.WriteLine("\nРЕЗУЛЬТАТ:"); 
    if (CrossPointExist (k1, b1, k2, b2))
    {
        Console.WriteLine($"\tТочка пересечения заданных вами прямых имеет координаты "+
                           $"({CrossPointAbscissa (k1, b1, k2, b2)};"+
                           $" {CrossPointOrdinate (k1, b1, k2, b2)}).\n"); 
    }
    else
    {
        if (b1 == b2) 
        {
            Console.WriteLine($"\tЗаданные Вами прямые совпадают: у них все точки общие. \n"); 
        }
        else
        {
            Console.WriteLine($"\tЗаданные Вами прямые параллельны: у них нет точек пересечения. \n"); 
        }
    }
}
else
{
    Console.WriteLine("\nТо, что Вы ввели, не является вещественным числом."+
                      "Программа заканчивает свою работу.\n"); 
}
     

bool InputDouble (string invit, out double number)
{
    Console.Write(invit); 
    return double.TryParse(Console.ReadLine(), out number); 
}

bool CrossPointExist (double k1, double b1, double k2, double b2)
{
    return (!(k1 == k2)); 
}

double CrossPointAbscissa (double k1, double b1, double k2, double b2) 
{
    return (b2 - b1) / (k1 - k2); 
}

double CrossPointOrdinate (double k1, double b1, double k2, double b2)
{
    return (k1 * b2 - k2 * b1) / (k1 - k2); 
}