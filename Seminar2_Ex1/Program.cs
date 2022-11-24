// Написать программу, которая вводит случайное число в диапазоне [10;99] 
// и показывает бОльшую из его цифр

Random random = new Random(); 
int number = random.Next(10,100);

Console.WriteLine(number); 

int firstNumber = number / 10; 
int lastNumber = number % 10; 

if (firstNumber > lastNumber) Console.WriteLine(firstNumber); 
else Console.WriteLine(lastNumber); 

