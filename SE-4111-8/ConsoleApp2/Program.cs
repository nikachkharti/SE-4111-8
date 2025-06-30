
internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = [10, 1, 2, 13, 44, 13];


        var result = FirstOrDefault(array, 132);

    }


    private static int FirstOrDefault(int[] collection, int element)
    {
        for (int i = 0; i < collection.Length; i++)
        {
            if (element == collection[i])
            {
                return collection[i];
            }
        }

        return default;
    }
    private static int Min(int[] array)
    {
        int min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }

        return min;
    }
    static double ToFarenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
    static void PrintHelloWorld(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Hello World!");
        }
    }
    static void PrintHi(string name)
    {
        Console.WriteLine($"Hi {name}");
    }
    static bool IsFunctionPalindrome(int[] collection)
    {
        int start = 0;
        int end = collection.Length - 1;

        while (start < end)
        {
            if (collection[start] != collection[end])
            {
                return false;
            }

            start++;
            end--;
        }

        return true;
    }

}