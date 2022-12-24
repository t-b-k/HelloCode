// Программа вычисления функции Аккермана. 
// Даны два неотрицательных числа - m и n.
// m = 2, n = 3 => A(m,n) = 9
// m = 3, n = 2 => A(m,n) = 29

// Функция Аккермана определяется рекурсивно для неотрицательных 
// целых чисел m и n следующим образом:
//              n+1, если m = 0
//   A(m,n) =   A(m-1,1), если n = 0
//              A(m-1, A(m, n-1)), если m > 0, n > 0

using static Common.Helper;

int m = 0;
int n = 0;

Console.WriteLine("Программа вычисляет значение функции Аккермана A(m,n) для заданных");
Console.WriteLine("неотрицательных чисел m и n.\n");

if (InputInteger("Введите целое неотрицательное число m => ", out m) &&
    InputInteger("Введите целое неотрицательное число n => ", out n) &&
    m >= 0 && n >= 0)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan; 
    Console.WriteLine($"\nРЕЗУЛЬТАТ: \n"); 
    
    double d_m = (double) m; 
    double d_n = (double) n; 

    Console.WriteLine($"A({m}, {n}) = {AccermanFunction(d_m,d_n)}");
    Console.WriteLine(); 
    Console.ResetColor(); 
}

double AccermanFunction (double m, double n)
{
    if (m == 0) return n+1; 
    else 
    {
        if (n == 0) return AccermanFunction(m-1, 1); 
        else return AccermanFunction (m-1, AccermanFunction(m, n-1)); 
    }
}
