// Напишите программу, которая принимает на вход 
// координаты двух точек и находит растояние между ними в 2D-пространстве

// AB = V AC2 + BC2

double inputDouble () 
{
    Console.WriteLine ("Введите целое число"); 
    bool isNum = double.TryParse(Console.ReadLine(), out double num);
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

double ax = inputDouble(); 
double ay = inputDouble(); 
double bx = inputDouble(); 
double by = inputDouble(); 

double GetDistanceBetweenTwoPoints (double ax, double ay, double bx, double by)
{
    double distance = Math.Sqrt((bx-ax)*(bx-ax) + (by-ay)*(by-ay)); 
    return distance; 
}

double ab = GetDistanceBetweenTwoPoints(ax, ay, bx, by); 

Console.WriteLine(ab); 