// Напишите программу, которая на вход принимает число N, 
// а на выход выдает все четные числа от 0 до N

Console.Clear(); 

Console.Write("Введите целое положительное число N => "); 

int number = int.Parse(Console.ReadLine()); 
Console.WriteLine(); 

int count = 0; 

if (number < 0) 
{
    Console.WriteLine("Извините, Ваше число не является положительным."); 
}
else
{
    Console.Write("Вот вам все четные числа в промежутке от 0 до "); 
    Console.Write(number);
    Console.WriteLine(":"); 
   
    while (count <= number-2) 
    {
        Console.Write(count); 
        Console.Write(", ");      
        count=count+2;  
    }

    Console.WriteLine(count); 
}

