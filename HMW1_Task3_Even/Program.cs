// Напишите программу, которая принимает на вход целое число
// и в качестве результата сообщает, является ли оно четным

Console.Clear();

Console.Write("Введите целое число а => ");
int a = int.Parse(Console.ReadLine());

Console.Write("Число "); 
Console.Write(a); 

if (a%2==0) 
    Console.WriteLine(" является четным."); 
else
    Console.WriteLine(" не является четным. "); 

Console.WriteLine(); 
