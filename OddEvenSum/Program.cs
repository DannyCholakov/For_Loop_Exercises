namespace OddEvenSum;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int evenNum = 0;
        int oddNum = 0;
        for (int i = 1; i <= n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if (i%2==0)
            {
                evenNum += number;
            }
            else
            {
                oddNum += number;
            }
        }

        if (oddNum==evenNum)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Sum = "+oddNum);
        }else if (oddNum>evenNum)
        {
            Console.WriteLine("No");
            Console.WriteLine("Diff = "+ (oddNum-evenNum));
        }else if (oddNum<evenNum)
        {
            Console.WriteLine("No");
            Console.WriteLine("Diff = "+ (evenNum-oddNum));
        }
    }
}