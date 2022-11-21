// Напишите программу, которая принимает на вход натуральное число N, 
// а на выходе показывает все целые числа от -N до N

int number = int.Parse(Console.ReadLine());


if (number<0) 
{
    Console.WriteLine("Введено отрицательное число");
}

int count = -number; 

while (count<number) 
{
    Console.Write(count);
    Console.Write(", ");
    count++; 
}
Console.WriteLine(count);