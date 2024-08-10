namespace NumberSequence;

class Program
{
    static void Main(string[] args)
    {
        int numbersCount = int.Parse(Console.ReadLine());
        
        // Четене на първото число
        int firstNumber = int.Parse(Console.ReadLine());
        int biggestNum = firstNumber;
        int smallestNum = firstNumber;

        for (int i = 1; i < numbersCount; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number > biggestNum)
            {
                biggestNum = number;
            }
            else if (number < smallestNum)
            {
                smallestNum = number;
            }
        }

        Console.WriteLine("Max number: " + biggestNum);
        Console.WriteLine("Min number: " + smallestNum);
    }
}