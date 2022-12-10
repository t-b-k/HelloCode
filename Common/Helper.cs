namespace Common;

public static class Helper
{
    public static bool InputPositiveInteger(string invit, out uint n)
    {
        Console.Write(invit);
        bool res = uint.TryParse(Console.ReadLine(), out n) && n != 0;
        return res;
    }
    public static void PrintArray(int[] array)
    {
        for (var i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            Console.Write(" ");
        }
    }

    public static int[] CreateRandomArray()
    {
        Random random = new Random();
        int[] array = new int[10];
        for (var i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(int.MinValue, int.MaxValue);
        }
        return array;
    }
}
