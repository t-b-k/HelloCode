Console.Write("Введите трехзначное число: ");

int number = int.Parse(Console.ReadLine());

if (number>=100&number<1000) 
{
    number = number % 10; 
    Console.WriteLine(number);
}
else
{
    Console.WriteLine("Прочитайте условие задачи еще раз!");
}