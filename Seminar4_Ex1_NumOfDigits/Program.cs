// Метод NumberOfDigits возвращает количество цифр в целом неотрицательном числе. 
// Если число отрицательное, метод возвращает 0

int NumberOfDigits(int num)
{
    int count = 0;
    if (num >= 0)
    {
        count = 1;
        while (num > 9)
        {
            num = num / 10;
            count++;
        }
    }
    return count;
}