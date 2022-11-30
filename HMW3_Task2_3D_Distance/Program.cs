// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между  ними в 3D-пространстве

double[] firstDotCoordinates = new double[3];    // Массив, в который мы запишем координаты первой точки
double[] secondDotCoordinates = new double[3];    // Массив, в который мы запишем координаты второй точки

double distance = 0; 
bool firstDotInputWrite = false; 
bool secondDotInputWrite = false; 

Console.WriteLine ("Введите координаты первой точки (дробную часть отделите запятой!) =>"); 
firstDotInputWrite = InputDotCoordinates(firstDotCoordinates); 

if (firstDotInputWrite) 
{
    Console.WriteLine ("Введите координаты второй точки (дробную часть отделите запятой!) =>"); 
    secondDotInputWrite = InputDotCoordinates(secondDotCoordinates); 

    if (secondDotInputWrite) 
    {
        distance = distBetweenDots3D(firstDotCoordinates, secondDotCoordinates); 
        Console.WriteLine ($"Расстояние между точками с введенными Вами координатами равно {distance}"); 
    }
    else 
    {
        Console.WriteLine ("Ошибка ввода. Программа завершает свою работу. "); 
    }
}
else 
{
    Console.WriteLine ("Ошибка ввода. Программа завершает свою работу. "); 
}

// Метод InputDotCoordinates возвращает значение "истина", если пользователь ввел последовательно 
// три вещественных значения. 
// В противном случае возвращает "ложь"

bool InputDotCoordinates (double[] dotCoords)
{

    bool marker = true;
    int count = 0;

    while (marker && count < dotCoords.Length)
    {
        Console.Write($"Введите {count+1}-ю координату: "); 
        Console.WriteLine(); 
        marker = double.TryParse(Console.ReadLine(), out double coord);
        dotCoords[count] = coord;
        count++;
    }
    return marker; 
}

// Метод distBetweenDots3D получает на вход два массива из 3-х вещественных элементов - 
// координат двух точек и выдает в качестве результата расстояние между ними

double distBetweenDots3D (double[] dot1, double[] dot2)
{
    double res = 0;
    for (int i = 0; i < 3; i++)
        res = res + Math.Pow(dot2[i] - dot1[i], 2);
    res = Math.Sqrt(res);
    return res;
}

