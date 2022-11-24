// Написать программу, которая выводит случайное 3-хзначное число
// и удаляет из него вторую цифру

Random random = new Random(); 
int number = random.Next(100,1000);

Console.WriteLine(number); 

int firstNumber = number / 100; 
int lastNumber = number % 10; 
int result = firstNumber*10 + lastNumber; 

Console.WriteLine(result); 

