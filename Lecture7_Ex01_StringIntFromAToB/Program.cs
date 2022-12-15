// Напишем метод, который печатает все целые значения в 
// диапазоне [a;b] через пробел. 

// сначала без рекурсии

string sampleString = string.Empty; 
int a = 0; 
int b = 9; 

string NumbersFor (int a, int b)
{
    string result = string.Empty; 
    for (int i = a; i<=b; i++)
    {
        result = result + $"{i} ";
    }
    return result; 
}

Console.WriteLine("Без рекурсии: \n"); 
sampleString = NumbersFor(a, b); 
Console.WriteLine(sampleString); 
Console.WriteLine(); 

// Теперь с рекурсией
Console.WriteLine("С рекурсией: \n"); 

string NumbersRec (int a, int b)
{
    string result = string.Empty; 
    
    if (a <= b) return ($"{a} " + NumbersRec (a+1, b)); 
    else return string.Empty; 
}

sampleString = NumbersRec(a, b); 
Console.WriteLine(sampleString); 
Console.WriteLine(); 

// допилим рекурсивный вариант, чтобы в нем было на один 
// цикл меньше

Console.WriteLine("С рекурсией, но вызовов на один меньше: \n"); 

string NumbersRecOpt (int a, int b)
{
    string result = string.Empty; 
    
    if (a < b) return ($"{a} " + NumbersRec (a+1, b)); 
    else 
        if (a == b) return $"{a}";  
        else return string.Empty; 
}

sampleString = NumbersRecOpt(a, b); 
Console.WriteLine(sampleString); 
Console.WriteLine(); 

// Выведем теперь числа в обратной последовательности

// сначала без рекурсии

Console.WriteLine("\nВыведем теперь те же числа в обратной последовательности: \n");

string BackNumbersFor (int a, int b)
{
    string result = string.Empty; 
    for (int i = a; i<=b; i++)
    {
        result = $"{i} " + result;
    }
    return result; 
}

Console.WriteLine("Без рекурсии: \n"); 
sampleString = BackNumbersFor(a, b); 
Console.WriteLine(sampleString); 
Console.WriteLine(); 


// Теперь с рекурсией

Console.WriteLine("Теперь с рекурсией: \n"); 

string BackNumbersRec (int a, int b)
{
    string result = string.Empty; 
    
    if (a < b) return (BackNumbersRec (a+1, b) + $" {a}"); 
    else 
        if (a == b) return $"{a}"; 
        else return string.Empty; 
}

sampleString = BackNumbersRec(a, b); 
Console.WriteLine(sampleString); 
Console.WriteLine(); 

// Посчитаем теперь сумму чисел от 1 до N

Console.WriteLine("Посчитаем сумму чисел от 1 до 9 без рекурсии: \n");

int sum = 0; 

int SumFor (int n)
{
    int result = 0; 

    for (int i = 1; i <= n; i++)
        result  = result + i; 
    return result; 
}

sum = SumFor(b); 
Console.WriteLine($"{sum}\n"); 

Console.WriteLine("и с рекурсией: \n");

int SumRec (int n)
{
    if (n == 1) return 1; 
    else 
       return n + SumRec(n-1);  
}

sum = 0; 
sum = SumRec(b);
Console.WriteLine($"{sum}\n"); 

// Посчитаем теперь a в степени N

a = 9; 
int n = 5; 

Console.WriteLine($"Посчитаем теперь {a} в степени {n} \n"); 
Console.WriteLine("Без рекурсии: \n"); 

int PowerFor (int a, int n)
{
    int result = 1; 
    for (int i = 1; i <= n; i++)
    {
        result *= a; 
    }
    return result; 
}

Console.WriteLine(PowerFor(a,n) + "\n"); 

Console.WriteLine("С рекурсией: \n"); 

int PowerRec (int a, int n)
{
    if (n < 0) return -1; 
    if (n == 0) return 1; 
    if (n > 1) return a * PowerRec(a, n-1); 
    else return a; 
}

Console.WriteLine(PowerRec(a,n) + "\n"); 

// другой вариант записи

int PowerRecN2 (int a, int n)
{
    return n == 0? 1 : PowerRec(a, n-1) * a; 
}

Console.WriteLine(PowerRecN2(a,n) + "\n"); 

// Сократим количество выполняемых операций, воспользовавшись формулой
// а в степени N = (а в квадрате в степени N/2) (для четных N)

int PowerRecMath (int a, int n)
{
    if (n == 0) return 1; 
    else if (n % 2 == 0) return PowerRecMath(a*a, n/2); 
    else return PowerRecMath(a, n - 1) * a; 
}

// П Е Р Е Б О Р    С Л О В

// В некотором машинном алфавите имеется 4 буквы - 
// "а", "и", "с" и "в".
// Покажите все слова из Т букв, которые можно построить
// с использованием символов этого алфавита. 
// Как решить эту задачу простым способом - итеративно? 

char[] s = {'а','и','с','в'};

int count = s.Length; 
n = 1; 
int t = 3; 

for (int i = 0; i < count; i++)
    for (int j = 0; j < count; j++)
        for (int k = 0; k < count; k++)
            {
                Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}"); 
            }

n = 1; 
void FindWords (string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); 
        return; 
    } 
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i]; 
        FindWords(alphabet, word, length+1); 
    }
}

FindWords("аисв", new char[2]);

// Алгоритм обхода директории: чтобы посмотреть, что находится в папке, 
// нужно просмотреть, что находится во вложенных папках


string path = "C:/Users/Татьяна Калашникова/Desktop/C#_Lecture1/EXAMPLES/Example002_HelloUser"; 
DirectoryInfo di = new DirectoryInfo(path);

System.Console.WriteLine(di.CreationTime); 





