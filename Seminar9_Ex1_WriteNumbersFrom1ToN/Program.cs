// See https://aka.ms/new-console-template for more information

// void Method (int i = 0) // Значение 0 будет использоваться по умолчанию, 
//                         // если мы не передадим в метод никакое значение
//                         // Но это i мы можем менять ТОЛЬКО в вызове метода
//                         // чтобы рекурсия работала правильно
// {
//     if (i == 5)
//     {
//         return;
//     }
//     Console.Write("?"); 
//     Method(i+1); 
// }

// void ME (int[] arr = null)
// {if (arr == null)
// {
//     arr = new int[5];  
// }}

SumFrom1ToN(5); 

void SumFrom1ToN (int n, int i = 1)
{
    
    if (n >= i) 
    {
       SumFrom1ToN(n-1); 
       Console.Write ($"{n} ");
    }
    else 
    {
        return;  
    }
   
}

void NatureNumbers (int n, int start = 1)
{
    if (n<start)
    {
        return; 
    }
    Console.Write($"{start} "); 
    NatureNumbers(start+1, n); 
}

void NatureNumbers2 (int n, int start = 1)
{
    if (n < start)
    {
        return; 
    }
    Console.Write($"{start} "); 
    NatureNumbers(n, start+1); ; 
}