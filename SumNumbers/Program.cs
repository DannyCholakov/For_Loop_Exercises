namespace SumNumbers;

class Program
{
    static void Main(string[] args)
    {
        int numbersCount = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 1; i <= numbersCount; i++)
        {
            int number = int.Parse(Console.ReadLine());
            count += number;
        }

        Console.WriteLine(count);
    }
}