// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник со сторонами такой длины
uint a = 0;
uint b = 0;
uint c = 0;

// Console.WriteLine("Введите целое положительное число - длину стороны А => ");

if (InputPositiveInteger("Введите длину стороны а => ", out a) &&
    InputPositiveInteger("Введите длину стороны в => ", out b) &&
    InputPositiveInteger("Введите длину стороны с => ", out c))
{

    // if (uint.TryParse(Console.ReadLine(), out uint num1) && num1 != 0)
    // {
    //     a = num1; 
    // }
    // else
    // {
    //    Console.WriteLine("Ошибка ввода. Программа прерывает свою работу. \n");
    //     return;
    // }

    // Console.WriteLine("Введите целое положительное число - длину стороны В => ");
    // if (uint.TryParse(Console.ReadLine(), out uint num2) && num2 != 0)
    // {
    //     b = num2; 
    // }
    // else
    // {
    //     Console.WriteLine("Ошибка ввода. Программа прерывает свою работу. \n");
    //     return;
    // }

    // Console.WriteLine("Введите целое положительное число - длину стороны C => ");
    // if (!uint.TryParse(Console.ReadLine(), out uint num3))
    // {
    //     Console.WriteLine("Ошибка ввода. Программа прерывает свою работу. \n");
    //     return;
    // }
    // else
    // {
    //     c = num3; 
    // }

    if (IsTriangle(a, b, c))
    {
        Console.WriteLine($"\nРЕЗУЛЬТАТ: \n\tТреугольник со сторонами {a}, {b} и {c} существует. \n");
    }
    else
    {
        Console.WriteLine($"\nРЕЗУЛЬТАТ: \n\tТреугольника со сторонами {a}, {b} и {c} не существует. \n");
    }
}
else
{
    Console.WriteLine("Вы ввели недопустимое значение. Программа прерывает свою работу. \n");
    return;
}

bool IsTriangle(uint a, uint b, uint c)
{
    return (a + b > c) && (a + c > b) && (b + c > a);
}

bool InputPositiveInteger(string invit, out uint n)
{
    Console.Write(invit);
    bool res = uint.TryParse(Console.ReadLine(), out n) && n != 0;
    return res;
}
