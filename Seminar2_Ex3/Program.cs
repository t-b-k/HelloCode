// Написать программу, которая принимает на вход два числа
// и выводит, является ли второе число кратным первому. 
// Если второе число не кратно первому, то программа 
// выводит остаток от деления

Console.Write("Введите первое число (отличное от нуля) => "); 

int firstNumber = int.Parse(Console.ReadLine()); 

Console.Write("Введите второе число (отличное от нуля) => "); 

int secondNumber = int.Parse(Console.ReadLine());

int rest = secondNumber % firstNumber; 

if (rest == 0) Console.WriteLine("Поздравляем! Второе число кратно первому.");
else 
{
    Console.Write ("Второе число не кратно первому. Остаток от деления равен "); 
    Console.WriteLine(rest); 
} 
